using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace Util
{
    public class PathUtil
    {
        public static string[] GetCurrSelectFolderPaths()
        {
            string[] paths = Selection.assetGUIDs;
            if (paths == null || paths.Length <= 0)
            {
                return null;
            }

            for (int i = 0; i < paths.Length; i++)
            {
                if (!string.IsNullOrEmpty(paths[i]))
                {
                    paths[i] = AssetDatabase.GUIDToAssetPath(paths[i]);
                }
            }

            return paths;
        }
    }

}

