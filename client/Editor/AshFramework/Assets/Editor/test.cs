using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class test
{
    [MenuItem("Help/test1")]
    public static void TestCmd()
    {
        var rua = EditorEx.CmdCaller.CreateCaller();
        rua.AddCommand("").RunCmd();
    }
}
