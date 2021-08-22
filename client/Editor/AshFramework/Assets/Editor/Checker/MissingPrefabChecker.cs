//引用自
//有修改
//作者：马三小伙儿 87410250
//地址：https://www.bilibili.com/video/BV1nh411U7iU
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Asset
{
    namespace Checker
    {
        public class MissingPrefabChecker
        {
            private const string PrefabNameColor = "#00FF00";
            private const string SubPrefabNameColor = "#FF0000";

            [MenuItem("Assets/CheckSelectMissingPrefab", priority = 2000)]
            private static void CheckMissingPrefabSelectFolder()
            {
                string[] paths = Util.PathUtil.GetCurrSelectFolderPaths();
                if(paths == null)
                {
                    Debug.LogWarning("can't get select path when check prefab");
                    return;
                }

                CheckMissingPrefab(paths);
            }

            private static void CheckMissingPrefab(string[] objPaths)
            {
                bool hasMissing = false;
                var guids = AssetDatabase.FindAssets("t:GameObject", objPaths);
                var length = guids.Length;
                var index = 1;
                foreach (var guid in guids)
                {
                    var path = AssetDatabase.GUIDToAssetPath(guid);
                    var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
                    EditorUtility.DisplayProgressBar("玩命检查中", "玩命检查中..." + path, (float)index / length);
                    bool missing = FindMissingPrefabRecursive(prefab, prefab.name, true);
                    hasMissing = missing ? true : hasMissing;
                }
                EditorUtility.ClearProgressBar();


                if (hasMissing)
                {
                    Debug.LogError("Check has missing prefab");
                }
                else
                {
                    string msg = "Check no missing prefab:       ";
                    foreach (var p in objPaths)
                        msg += p + "        ";
                    Debug.Log(msg);
                }
            }

            static bool FindMissingPrefabRecursive(GameObject gameObject, string prefabName, bool isRoot)
            {
                if (gameObject.name.Contains("Missing Prefab"))
                {
                    Debug.LogError(
                        $"<color={PrefabNameColor}>{prefabName}</color> has missing prefab <color={SubPrefabNameColor}>{gameObject.name}</color>");
                    return true; 
                }

                if (PrefabUtility.IsPrefabAssetMissing(gameObject))
                {
                    Debug.LogError(
                        $"<color={PrefabNameColor}>{prefabName}</color> has missing prefab <color={SubPrefabNameColor}>{gameObject.name}</color>");
                    return true;
                }

                if (PrefabUtility.IsDisconnectedFromPrefabAsset(gameObject))
                {
                    Debug.LogError(
                        $"<color={PrefabNameColor}>{prefabName}</color> has missing prefab <color={SubPrefabNameColor}>{gameObject.name}</color>");
                    return true;
                }

                if (!isRoot)
                {
                    if (PrefabUtility.IsAnyPrefabInstanceRoot(gameObject))
                    {
                        return false;
                    }

                    GameObject root = PrefabUtility.GetNearestPrefabInstanceRoot(gameObject);
                    if (root == gameObject)
                    {
                        return false;
                    }
                }

                bool hasMissing = false;
                foreach (Transform childT in gameObject.transform)
                {
                    bool missing = FindMissingPrefabRecursive(childT.gameObject, prefabName, false);
                    hasMissing = missing ? true : hasMissing;
                }
                return hasMissing;
            }
        }
    }
}