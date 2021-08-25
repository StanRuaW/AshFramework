using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class test
{
    [MenuItem("Help/test1")]
    public static async void TestCmd()
    {
        var rua = EditorEx.CMD.GetNewCaller(@"D:\AshFramework\luban\src\Luban.Client\bin\Debug\net5.0", "Luban.Client.exe");
        rua.AddArgument("-h", "127.0.0.1").
            AddArgument("-j", "cfg").
            AddArgument("--", "").
            AddArgument("-d", "Defines/__root__.xml").
            AddArgument("--input_data_dir", "Datas").
            AddArgument("--output_code_dir", "output_code").
            AddArgument("--output_data_dir", "output_data").
            AddArgument("-s", "server").
            AddArgument("--gen_types", "code_cs_bin,data_bin").
            SetDictionary(@"D:\AshFramework\luban\config");
        var rue = await rua.RunCmd();
        Debug.Log(rue.StandardOutput);

        //TODO:����log��־
        //TODO���Զ��򿪺͹ر�server
    }
}
