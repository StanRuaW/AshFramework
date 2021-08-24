//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using CliWrap;

//namespace EditorEx
//{
//    public class CmdCaller
//    {
//        public static CMD CreateCaller()
//        {
//            return new CMD();
//        }

//        public class CMD
//        {
//            private string commands;
//            private string arguments;
//            private string workDictionary = "./";
//            public CMD AddCommand(string line)
//            {
//                //TODO:stringbuilder?
//                commands += "\n" + line;
//                return this;
//            }

//            public CMD AddArgument(string argA, string argB)
//            {
//                //TODO:stringbuilder?
//                arguments += "--" + argA + " " + argB;
//                return this;
//            }

//            public CMD SetDictionary(string dic)
//            {
//                //TODO:验证地址合法性
//                workDictionary = dic;
//                return this;
//            }

//            public void RunCmd()
//            {
//                //TODO:await
//                var result = Cli.Wrap(commands).WithArguments(arguments).WithWorkingDirectory(workDictionary).ExecuteAsync();
//                Debug.Log(result.ToString());
//                //TODO:log结果，缓存log文件
//            }
//        }
//    }
//}