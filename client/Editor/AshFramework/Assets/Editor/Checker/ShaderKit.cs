//引用自
//作者：马三小伙儿 bilibili id:87410250
//地址：https://www.bilibili.com/video/BV1nh411U7iU
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Asset
{
    namespace Checker
    {
        public class ShaderKit
        {
            private const string ShaderPath = "Assets/GameAssets/Shaders";//TODO:路径配置
            private static string OutputPath = "Shader";

            [MenuItem("Tools/变体统计", priority = 21)]
            public static void CalcAllShaderVariantCount()
            {
                var asm = typeof(SceneView).Assembly;
                System.Type type = asm.GetType("UnityEditor.ShaderUtil");
                MethodInfo method = type.GetMethod("GetVariantCount",
                    BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                var shaderList = AssetDatabase.FindAssets("t:Shader", new[] { ShaderPath });
                string date = System.DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss");
                string pathF = string.Format("{0}/ShaderVariantCount{1}.csv", OutputPath, date);
                FileStream fs = new FileStream(pathF, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

                EditorUtility.DisplayProgressBar("Shader统计文件", "正在写入统计文件中...", 0f);
                int ix = 0;
                sw.WriteLine("Shader 数量：" + shaderList.Length);
                sw.WriteLine("ShaderFile, VariantCount");
                int totalCount = 0;
                foreach (var i in shaderList)
                {
                    EditorUtility.DisplayProgressBar("Shader统计文件", "正在写入统计文件中...", ix / shaderList.Length);
                    var path = AssetDatabase.GUIDToAssetPath(i);
                    Shader s = AssetDatabase.LoadAssetAtPath(path, typeof(Shader)) as Shader;
                    var variantCount = method.Invoke(null, new System.Object[] { s, true });
                    sw.WriteLine(path + "," + variantCount.ToString());
                    totalCount += int.Parse(variantCount.ToString());
                    ++ix;
                }

                sw.WriteLine("Shader Variant Total Amount: " + totalCount);
                EditorUtility.ClearProgressBar();
                sw.Close();
                fs.Close();
            }
        }
    }
}