//引用
//作者：马三小伙儿 bilibili id:87410250
//地址：https://github.com/XINCGer/UnityToolchainsTrick
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Asset.Checker
{
    public class MissingComponentChecker
    {
        private const string PrefabNameColor = "#00FF00";
        private const string PathColor = "#0000FF";

        [MenuItem("Tools/Checker/查找所有缺失组件")]
        private static void CheckMissingComponentAll()
        {
            string path = Asset.PathUtil.GetAssetsRootPath();
            MissingComponentCheck(new[] { path });
        }

        [MenuItem("GameObject/Checker/查找所有缺失预制体的引用")]
        private static void CheckMissingComponentInScene()
        {
            Debug.Log("TODO");
        }

        [MenuItem("Assets/CheckSelectMissingComponent", priority = 2001)]
        private static void CheckMissingComponentSelectFolder()
        {
            string[] paths = Asset.PathUtil.GetCurrSelectFolderPaths();
            if (paths == null)
            {
                Debug.LogWarning("can't get select path when check prefab");
                return;
            }

            MissingComponentCheck(paths);
        }

        private static void MissingComponentCheck(string[] objPaths)
        {
            bool hasMissing = false;
            var guids = AssetDatabase.FindAssets("t:GameObject", objPaths);
            var length = guids.Length;
            var index = 1;
            foreach (var guid in guids)
            {
                var path = AssetDatabase.GUIDToAssetPath(guid);
                EditorUtility.DisplayProgressBar("玩命检查中", "玩命检查中..." + path, (float)index / length);
                var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
                bool missing = FindMissingComponentRecursive(prefab, prefab, path);
                index++;
                hasMissing = missing ? true : hasMissing;
            }
            EditorUtility.ClearProgressBar();

            if (hasMissing)
            {
                Debug.LogError("Check has missing component");
            }
            else
            {
                string msg = "Check no missing component:       ";
                foreach (var p in objPaths)
                    msg += p + "        ";
                Debug.Log(msg);
            }

            static bool FindMissingComponentRecursive(GameObject gameObject, GameObject prefab, string path)
            {
                var cmps = gameObject.GetComponents<Component>();
                for (int i = 0; i < cmps.Length; i++)
                {
                    if (null == cmps[i])
                    {
                        Debug.LogError(
                            $"<color={PrefabNameColor}>{GetRelativePath(gameObject, prefab)}</color> has missing components! path is: <color={PathColor}>{path}</color>"
                        );
                        return true;
                    }
                }

                bool hasMissing = false;
                foreach (Transform trans in gameObject.transform)
                {
                    bool missing = FindMissingComponentRecursive(trans.gameObject, prefab, path);
                    hasMissing = missing ? true : hasMissing;
                }
                return hasMissing;

                static string GetRelativePath(GameObject gameObject, GameObject prefab)
                {
                    if (null == gameObject.transform.parent)
                    {
                        return gameObject.name;
                    }
                    else if (gameObject == prefab)
                    {
                        return gameObject.name;
                    }
                    else
                    {
                        return GetRelativePath(gameObject.transform.parent.gameObject, prefab) + "/" + gameObject.name;
                    }
                }
            }
        }    
    }
}