using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using EditorEx;
using CliWrap.Buffered;

namespace cfg
{
	public class LubanGenMgr
	{
		private static readonly string _clientName = "Luban.ClientServer.exe";
		private static readonly string _clientPath = @"D:\AshFrame\luban\src\Luban.ClientServer\bin\Debug\net5.0";
		private static readonly string _defineFile = @"Defines/__root__.xml";
		private static readonly string _inputDataDir = @"Datas";
		private static readonly string _outputCodeDir = @"..\..\client\Editor\AshFramework\Assets\Config\output_code";
		private static readonly string _outputDataDir = @"..\..\client\Editor\AshFramework\Assets\Config\output_data";
		private static readonly string _workingPath = @"D:\AshFrame\luban\config";

		private static string _ip;
		private static string _port;
		private static string _serviceTarget;
		private static string _genTypes;
		private static bool _exportTestData;

		private static CMD _cmd;

		public static async Task<BufferedCommandResult> BuildAllConfigAsync()
		{
			InitDefaultCMD();
			return await Run();
			//TODO：会不会有多次执行的冲突
		}

		private static CMD InitDefaultCMD() {
			_ip = "127.0.0.1";
			_port = "8899";
			_serviceTarget = "all";
			_genTypes = "code_cs_bin,data_bin";
			_exportTestData = false;

			_cmd = CMD.GetNewCaller( _clientName, _clientPath );

			//_cmd.AddArgument( "-h", _ip );
			//_cmd.AddArgument( "-p", _port );
			_cmd.AddArgument( "-j", "cfg" );
			_cmd.AddArgument( "--", "" );
			_cmd.AddArgument( "-d", _defineFile );
			_cmd.AddArgument( "--input_data_dir", _inputDataDir );
			_cmd.AddArgument( "--output_code_dir", _outputCodeDir );
			_cmd.AddArgument( "--output_data_dir", _outputDataDir );
			_cmd.AddArgument( "-s", _serviceTarget );
			_cmd.AddArgument( "--gen_types", _genTypes );
			if (_exportTestData)
				_cmd.AddArgument( "--export_test_data", "" );
			//TODO: -w

			//TODO:meta文件刷新会不会有问题

			return _cmd;
		}

		private static async Task<BufferedCommandResult> Run()
		{
			if (_cmd != null)
			{
				_cmd.SetDictionary( _workingPath );
				return await _cmd.RunCmdAsync();
			}
			else
			{
				return null;
			}
		}
	}
}
