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
        private Command wrapper;
        private string arguments = "";
        private string workDictionary = "./";

        private CMD(string command, string path)
        {
            wrapper = Cli.Wrap(path + @"\" + command);
        }

        public static CMD GetNewCaller(string command, string path = "")
        {
            if (string.IsNullOrEmpty(path))
            {
                //TODO:默认目录用这个吗,而且不是unity的接口
                path = Directory.GetCurrentDirectory();
            }
            return new CMD(command, path);
        }

        public CMD AddArgument(string argA, string argB)
        {
            //TODO:stringbuilder?
            arguments += argA + " " + argB + " ";
            return this;
        }

        public CMD SetDictionary(string dic)
        {
            //TODO:验证地址合法性
            workDictionary = dic;
            return this;
        }

        public async Task<BufferedCommandResult> RunCmd()
        {
            return await wrapper.WithArguments(arguments).
                                 WithWorkingDirectory(workDictionary).
                                 WithValidation(CommandResultValidation.None).
                                 ExecuteBufferedAsync();

            //var result = await Cli.Wrap(@"D:\AshFramework\luban\src\Luban.Client\bin\Debug\net5.0\Luban.Client.exe").WithArguments(@"-h 127.0.0.1 " + "-j cfg " + "-- " + "-d Defines/__root__.xml " + "--input_data_dir Datas " + "--output_code_dir output_code " + "--output_data_dir output_data " + "-s server " + "--gen_types code_cs_bin,data_bin " + "--export_test_data").WithWorkingDirectory(@"D:\AshFramework\luban\config").WithValidation(CommandResultValidation.None).ExecuteBufferedAsync();
        }
    }

}