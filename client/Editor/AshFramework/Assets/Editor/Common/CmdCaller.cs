using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CliWrap;
using CliWrap.Buffered;
using System.IO;

namespace EditorEx
{
    public class CmdCaller
    {
        public static CMD CreateCaller()
        {
            return new CMD();
        }

        public class CMD
        {
            private string commands = "";
            private string arguments = "";
            private string workDictionary = "./";
            public CMD AddCommand(string line)
            {
                //TODO:stringbuilder?
                commands += line + '\n';
                return this;
            }

            public CMD AddArgument(string argA, string argB)
            {
                //TODO:stringbuilder?
                arguments += "--" + argA + " " + argB;
                return this;
            }

            public CMD SetDictionary(string dic)
            {
                //TODO:验证地址合法性
                workDictionary = dic;
                return this;
            }

            public void RunCmd()
            {
                //TODO:await
                // CommandTask<BufferedCommandResult> result = Cli.Wrap("Luban.Client.exe").WithWorkingDirectory("../../../../../../luban/src/Luban.Client/bin/Debug/net5.0/").ExecuteBufferedAsync();
                //Debug.Log(result.GetAwaiter().GetResult().StandardOutput);
                //Debug.Log(result.GetAwaiter().GetResult().);

                //Debug.Log(Directory.GetCurrentDirectory());
                //CommandTask<BufferedCommandResult> result = Cli.Wrap("Luban.Client.exe").WithArguments("--a a").WithWorkingDirectory("D:\\AshFramework\\luban\\src\\Luban.Client\\bin\\Debug\\net5.0").WithValidation(CommandResultValidation.None).ExecuteBufferedAsync();
                //Debug.Log(result.Task.Result.StandardOutput);

                CommandTask<BufferedCommandResult> result = Cli.Wrap("ipconfig").WithArguments("--a a").WithWorkingDirectory(Directory.GetCurrentDirectory()+"/Assets").WithValidation(CommandResultValidation.None).ExecuteBufferedAsync();
                Debug.Log(result.Task.Result.StandardOutput);
                //TODO:log结果，缓存log文件
            }
        }
    }
}