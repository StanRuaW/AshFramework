//引用自
//作者：马三小伙儿 bilibili id:87410250
//地址：https://github.com/XINCGer/UnityToolchainsTrick
using System;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;

namespace EditorEx
{
    /// <summary>
    /// 打开文件以及文件夹的扩展
    /// </summary>
    public static class OpenExtension
    {
        [MenuItem("Assets/OpenRoot", false, 10000)]
        public static void OpenProjectRootPath()
        {
			Asset.PathUtil.Execute(Application.dataPath + "/../../../../");
        }

        [MenuItem("Assets/OpenAssets", false, 10001)]
        public static void OpenFolderDataPath()
        {
            Asset.PathUtil.Execute(Application.dataPath);
        }

        [MenuItem("Assets/OpenLuban", false, 10001)]
        public static void OpenLubanFolder()
        {
            Asset.PathUtil.Execute(Application.dataPath + "/../../../../" + "luban/");
        }
		
		[MenuItem("Assets/OpenDoc", false, 10002)]
        public static void OpenDocFolder()
        {
            Asset.PathUtil.Execute(Application.dataPath + "/../../../../" + "doc/");
        }


        ///// <summary>
        ///// 打开 Persistent Data Path 文件夹。
        ///// </summary>
        //[MenuItem("Assets/Open Folder/Persistent Data Path", false, 10001)]
        //public static void OpenFolderPersistentDataPath()
        //{
        //    Asset.PathUtil.Execute(Application.persistentDataPath);
        //}

        ///// <summary>
        ///// 打开 Streaming Assets Path 文件夹。
        ///// </summary>
        //[MenuItem("Assets/Open Folder/Streaming Assets Path", false, 10002)]
        //public static void OpenFolderStreamingAssetsPath()
        //{
        //    Asset.PathUtil.Execute(Application.streamingAssetsPath);
        //}

        ///// <summary>
        ///// 打开 Temporary Cache Path 文件夹。
        ///// </summary>
        //[MenuItem("Assets/Open Folder/Temporary Cache Path", false, 10003)]
        //public static void OpenFolderTemporaryCachePath()
        //{
        //    Asset.PathUtil.Execute(Application.temporaryCachePath);
        //}

        //[MenuItem("Assets/Open Files/OpenExcel")]
        //public static void OpenExcel()
        //{
        //    string[] suffixs = new[]
        //    {
        //        "xlsx",
        //        "xls",
        //        "csv",
        //    };
        //    var objects = Selection.objects;
        //    if (objects != null && objects.Length > 0)
        //    {
        //        foreach (var o in objects)
        //        {
        //            string path = AssetDatabase.GetAssetPath(o);
        //            if (o is TextAsset)
        //            {
        //                string suffix = path.Substring(path.LastIndexOf(".") + 1);
        //                if (Array.IndexOf(suffixs, suffix) == -1)
        //                {
        //                    UnityEngine.Debug.LogWarningFormat("selection file {0} , suffixes not supported", path);
        //                    continue;
        //                }
        //                path = string.Format("\"{0}\"", path);
        //                switch (Application.platform)
        //                {
        //                    case RuntimePlatform.WindowsEditor:
        //                        Process.Start("excel", path.Replace('/', '\\'));
        //                        break;

        //                    case RuntimePlatform.OSXEditor:
        //                        Process.Start("open", path);
        //                        break;
        //                    default:
        //                        throw new Exception(string.Format("Not support open folder on '{0}' platform.",
        //                            Application.platform.ToString()));
        //                }
        //            }
        //            else
        //            {
        //                UnityEngine.Debug.LogWarningFormat("selection file {0} , suffixes not supported", path);
        //            }
        //        }
        //    }
        //}
    }
}
