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
		private static readonly string _clientName = "Luban.Client.exe";
		private static readonly string _clientPath = @"D:\AshFrame\luban\src\Luban.Client\bin\Debug\net5.0";

		public async Task<BufferedCommandResult> BuildAllConfigAsync()
		{
			//TODO：会不会有多次执行的冲突
			_cmd = CMD.GetNewCaller( _clientName, _clientPath );

			if (string.IsNullOrEmpty(_ip))
			{
				SetLocalIP();
			}
			_cmd.AddArgument( "-h", _ip );

			//TODO:
			_cmd.AddArgument( "-j", "cfg" );
			_cmd.AddArgument( "--", "" );


			throw new System.NotImplementedException();
		}

		public async Task<BufferedCommandResult> CleanAllConfigAsync()
		{
			throw new System.NotImplementedException();
		}

		public void SetLocalIP()
		{
			_ip = "127.0.0.1";
		}

		private CMD _cmd;
		private string _ip;

		private void SetIP(string ip)
		{
			//TODO:check
			_ip = ip;
		}


	}

}
