using Bright.Net.ServiceModes.Managers;
using Bright.Time;
using Luban.Common.Protos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Luban.Server.Common
{
    public class ReadRemoteFailException : Exception
    {
        public ReadRemoteFailException()
        {
        }

        public ReadRemoteFailException(string message) : base(message)
        {
        }

        public ReadRemoteFailException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReadRemoteFailException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    public class RemoteAgent
    {
        private static readonly NLog.Logger s_logger = NLog.LogManager.GetCurrentClassLogger();

        public SessionBase Session { get; }

        private readonly bool _trace;

        private readonly Dictionary<string, Task<byte[]>> _remoteReadAllBytesTasks = new Dictionary<string, Task<byte[]>>();

        private readonly Dictionary<string, Task<GetImportFileOrDirectoryRes>> _getImportFileOrDirTasks = new Dictionary<string, Task<GetImportFileOrDirectoryRes>>();

        public RemoteAgent(SessionBase session, bool trace)
        {
            Session = session;
            _trace = trace;
        }

        private const int GET_INPUT_FILE_TIMEOUT = 10;

        public async Task<byte[]> GetFromCacheOrReadAllBytesAsync(string file, string md5)
        {
            var cache = CacheManager.Ins.FindCache(md5);
            if (cache != null)
            {
                return cache.Content;
            }
            var content = await ReadAllBytesAsync(file).ConfigureAwait(false);
            CacheManager.Ins.AddCache(file, md5, content);
            return content;
        }

        public Task<byte[]> ReadAllBytesAsync(string file)
        {
            lock (_remoteReadAllBytesTasks)
            {
                if (!_remoteReadAllBytesTasks.TryGetValue(file, out var task))
                {
                    task = Task.Run(async () =>
                    {
                        long t1 = TimeUtil.NowMillis;
                        var res = await Session.CallRpcAsync<GetInputFile, GetInputFileArg, GetInputFileRes>(new GetInputFileArg() { File = file }, GET_INPUT_FILE_TIMEOUT);
                        if (res.Err != Luban.Common.EErrorCode.OK)
                        {
                            throw new ReadRemoteFailException($"{res.Err}");
                        }
                        s_logger.Info("read remote file:{file} cost:{time}", file, TimeUtil.NowMillis - t1);
                        return res.Content;
                    });
                    task.ConfigureAwait(false);
                    _remoteReadAllBytesTasks.Add(file, task);
                }
                return task;
            }

        }

        public Task<GetImportFileOrDirectoryRes> GetFileOrDirectoryAsync(string file)
        {
            lock (_getImportFileOrDirTasks)
            {
                if (!_getImportFileOrDirTasks.TryGetValue(file, out var task))
                {
                    task = Task.Run(async () =>
                    {
                        long t1 = TimeUtil.NowMillis;
                        var res = await Session.CallRpcAsync<GetImportFileOrDirectory, GetImportFileOrDirectoryArg, GetImportFileOrDirectoryRes>(
                            new GetImportFileOrDirectoryArg() { FileOrDirName = file },
                            GET_INPUT_FILE_TIMEOUT);
                        if (res.Err != Luban.Common.EErrorCode.OK)
                        {
                            throw new ReadRemoteFailException($"ReadFile:{file} fail. {res.Err}");
                        }
                        s_logger.Trace("read GetFileOrDirectoryAsync end. file:{file} cost:{time}", file, TimeUtil.NowMillis - t1);
                        return res;
                    });
                    _getImportFileOrDirTasks.Add(file, task);
                }
                return task;
            }

        }

        const int QUERY_FILE_EXISTS_TIMEOUT = 10;

        public async Task<QueryFilesExistsRes> QueryFileExistsAsync(QueryFilesExistsArg arg)
        {
            long t1 = TimeUtil.NowMillis;
            var res = await Session.CallRpcAsync<QueryFilesExists, QueryFilesExistsArg, QueryFilesExistsRes>(arg, QUERY_FILE_EXISTS_TIMEOUT);

            s_logger.Trace("query file exists. count:{count} cost:{time}", arg.Files.Count, TimeUtil.NowMillis - t1);
            return res;
        }

        public async Task<XElement> OpenXmlAsync(string xmlFile)
        {
            try
            {
                s_logger.Trace("open {xml}", xmlFile);
                return XElement.Load(new MemoryStream(await ReadAllBytesAsync(xmlFile)));
            }
            catch (Exception e)
            {
                throw new Exception($"打开定义文件:{xmlFile} 失败 --> {e.Message}");
            }
        }


        #region log

        public void Error(string fmt, params object[] objs)
        {
            Log("error", string.Format(fmt, objs));
        }

        public void Error(Exception e, string s)
        {
            LogException(e, s);
        }

        public void Error(Exception e, string fmt, params object[] objs)
        {
            LogException(e, string.Format(fmt, objs));
        }

        public void Info(string fmt, params object[] objs)
        {
            Log("info", string.Format(fmt, objs));
        }

        public void Info(string s)
        {
            Log("info", s);
        }

        public void Trace(string fmt, params object[] objs)
        {
            if (_trace)
            {
                Log("trace", string.Format(fmt, objs));
            }
        }

        private void Log(string level, string content)
        {
            Session.Send(new PushLog() { Level = level, LogContent = content });
        }

        private void LogException(Exception e, string content)
        {
            Session.Send(new PushException() { LogContent = content, Message = e.Message, StackTrace = e.StackTrace });
        }
        #endregion
    }
}
