using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Asset
{
    public class ScriptObjectMgr : SingletonMono<ScriptObjectMgr>
    {
        protected override void Init()
        {
            base.Init();
        }

        protected override void Dispose()
        {
            base.Dispose();
        }

        public static void SafeSaveScriptObject(UnityEngine.Object obj)
        {
            EditorUtility.SetDirty(obj);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
    }
}
