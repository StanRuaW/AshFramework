using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class test
{
    [MenuItem("Help/test1")]
    public static async void TestCmd()
    {
        var rua = EditorEx.CmdCaller.CreateCaller();
        var rue = await rua.AddCommand("").RunCmd();
        Debug.Log(rue.StandardOutput);
    }
}
