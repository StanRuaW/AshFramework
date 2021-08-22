using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Asset
{
    public class ScriptObjectMgr : SingletonMono<ScriptObjectMgr>
    {
        public override void Initialize()
        {

        }

        public override void Dispose()
        {

        }

        public static void SafeSaveScriptObject(UnityEngine.Object obj)
        {
            EditorUtility.SetDirty(obj);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
    }
}
