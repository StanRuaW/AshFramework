using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CliWrap;
using CliWrap.Buffered;
using System.IO;
using System.Threading.Tasks;

namespace EditorEx
{
    public class CMD
    {
        public static CMD GetNewCaller(string command, string path = "")
        {
            if (string.IsNullOrEmpty(path))
            {
                //TODO:默认目录用这个吗,而且不是unity的接口
                path = Directory.GetCurrentDirectory();
            }
            return new CMD(command, path);
        }

		#region 参数
		public bool AddArgument(string argA, string argB)
        {
			if(HasArgument(argA))
			{
				Debug.LogError( $"Add same argument {argA}" );
				return false;
			}

			if(!IsValidArgument(argA,argB))
			{
				Debug.LogError( $"Not Valid argument when add {argA} {argB}" );
				return false;
			}

			_arguments.Add( argA, CombineArgumentAB( argA, argB ) );
			return true;
        }

		public bool ChangeArgument(string argA, string argB )
		{
			if(!HasArgument(argA))
			{
				Debug.LogError( $"Change null argument {argA}" );
				return false;
			}

			if (!IsValidArgument( argA, argB ))
			{
				Debug.LogError( $"Not Valid argument when change {argA} {argB}" );
				return false;
			}

			_arguments[argA] = CombineArgumentAB( argA, argB );
			return true;
		}

		public string CombineArgumentAB(string argA, string argB)
		{
			//TODO:stringbuilder?
			return $"{argA} {argB}";
		}

		public bool HasArgument(string argA )
		{
			return _arguments.ContainsKey( argA );
		}

		public bool IsValidArgument(string argA,string argB)
		{
			//TODO:
			return true;
		}

		public bool RemoveArgument(string argA )
		{
			if(!HasArgument(argA))
			{
				Debug.LogError( $"Remove null argument {argA}" );
				return false;
			}

			_arguments.Remove( argA );
			return true;
		}
		#endregion

		public void SetDictionary(string dic)
        {
            //TODO:验证地址合法性
            _workDictionary = dic;
        }

        public async Task<BufferedCommandResult> RunCmdAsync()
		{
			string arguments = "";
			//TODO：检查顺序问题怎么办
			foreach(var a in _arguments)
			{
				arguments += a.Value + " ";
			}

			return await _wrapper.WithArguments(arguments).WithWorkingDirectory( _workDictionary ).
								  WithValidation( CommandResultValidation.None ).
								  ExecuteBufferedAsync();

            //var result = await Cli.Wrap(@"D:\AshFramework\luban\src\Luban.Client\bin\Debug\net5.0\Luban.Client.exe").WithArguments(@"-h 127.0.0.1 " + "-j cfg " + "-- " + "-d Defines/__root__.xml " + "--input_data_dir Datas " + "--output_code_dir output_code " + "--output_data_dir output_data " + "-s server " + "--gen_types code_cs_bin,data_bin " + "--export_test_data").WithWorkingDirectory(@"D:\AshFramework\luban\config").WithValidation(CommandResultValidation.None).ExecuteBufferedAsync();
        }

        private Command _wrapper;
		private Dictionary<string,string> _arguments;
        private string _workDictionary = "./";

        private CMD(string command, string path)
        {
            _wrapper = Cli.Wrap(path + @"\" + command);
			_arguments = new Dictionary<string, string>();
		}

    }

}
