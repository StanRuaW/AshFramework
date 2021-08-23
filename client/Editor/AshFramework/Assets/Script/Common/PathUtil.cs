using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;


namespace Util
{
    public class PathUtil
    {
        #region 获取指定路径
        public static string GetAssetsRootPath()
        {
            //TODO:构建后不同平台的地址
            return Application.dataPath;
        }

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
        #endregion

        #region 路径转换
        public static string GetRegularPath(string path)
        {
            return path?.Replace('\\', '/');
        }

        public static string GetCombinePath(params string[] path)
        {
            if (path == null || path.Length < 1)
                return (string)null;
            string str = path[0];
            for (int index = 1; index < path.Length; ++index)
                str = System.IO.Path.Combine(str, path[index]);
            return GetRegularPath(str);
        }

        public static string GetCombinePath(int startIndex, int endIndex, params string[] path)
        {
            if (path == null || path.Length < 1)
                return (string)null;
            if (startIndex < 0 || startIndex >= path.Length - 1 || endIndex < 0 || endIndex > path.Length - 1 || startIndex > endIndex)
            {
                return (string)null;
            }

            string str = path[startIndex];
            for (int index = startIndex + 1; index <= endIndex; ++index)
                str = System.IO.Path.Combine(str, path[index]);
            return GetRegularPath(str);
        }

        public static string GetRemotePath(params string[] path)
        {
            string combinePath = GetCombinePath(path);
            if (combinePath == null)
                return (string)null;
            if (!combinePath.Contains("://"))
                return ("file:///" + combinePath).Replace("file:////", "file:///");
            return combinePath;
        }

        public static string AbsolutePath2RelativePath(string absolutePath)
        {
            //TODO:
            return "";
        }

        public static string RelativePath2AbsolutePath(string relativePath)
        {
            //TODO:
            return "";
        }

        public static string GetAssetDirectoryName(string assetPath)
        {
            return System.IO.Path.GetDirectoryName(assetPath);
        }

        public static string[] GetProgressiveAssetFolderPath(string assetFolderPath)
        {
            if (assetFolderPath.IndexOf(Path.DirectorySeparatorChar) != -1)
            {
                string[] folderName = assetFolderPath.Split(Path.DirectorySeparatorChar);
                string[] result = new string[folderName.Length];
                for (int i = 0; i < folderName.Length; i++)
                {
                    result[i] = GetCombinePath(0, i, folderName);
                }

                return result;
            }

            return null;
        }
        #endregion

        #region 文件夹操作
        /// <summary>移除空文件夹。</summary>
        /// <param name="directoryName">要处理的文件夹名称。</param>
        /// <returns>是否移除空文件夹成功。</returns>
        public static bool RemoveEmptyDirectory(string directoryName)
        {
            if (string.IsNullOrEmpty(directoryName))
                throw new Exception("Directory name is invalid.");
            try
            {
                if (!Directory.Exists(directoryName))
                    return false;
                string[] directories = Directory.GetDirectories(directoryName, "*");
                int length = directories.Length;
                foreach (string directoryName1 in directories)
                {
                    if (RemoveEmptyDirectory(directoryName1))
                        --length;
                }

                if (length > 0 || Directory.GetFiles(directoryName, "*").Length != 0)
                    return false;
                Directory.Delete(directoryName);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }

}

