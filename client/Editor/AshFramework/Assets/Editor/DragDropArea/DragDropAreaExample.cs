/***
 *
 *  Title:
 *  
 *  Description:
 *  
 *  Date:
 *  Version:
 *  Writer: ��ֻ��Ϻ��
 *  Github: https://github.com/HalfLobsterMan
 *  Blog: https://www.crosshair.top/
 *
 */
using CZToolKit.Core.Editors;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

using UnityObject = UnityEngine.Object;

namespace Editor
{
    namespace DragDropArea
    {
        public class DragDropAreaExample : EditorWindow
        {
            [MenuItem("Tools/DragDropAreaExample")]
            public static void Open()
            {
                GetWindow<DragDropAreaExample>();
            }

            SerializedObject serializedObject;

            private void OnEnable()
            {
                serializedObject = new SerializedObject(this);
            }

            public List<UnityObject> objects = new List<UnityObject>();

            private void OnGUI()
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("objects"));

                UnityObject obj = EditorGUILayoutExtension.DragDropAreaSingle(GUILayout.Height(50));
                GUI.Box(GUILayoutUtility.GetLastRect(), "ʹ��GUILayout��ʽ���ƽ��յ�����Դ��������ָ��Rect", "GroupBox");
                if (obj != null)
                {
                    objects.Add(obj);
                    serializedObject.ApplyModifiedProperties();
                    serializedObject.Update();
                }

                Rect r = GUILayoutUtility.GetRect(50, 50);
                GUI.Box(r, "ʹ��GUI��ʽ���ƽ��յ�����Դ������ָ��Rect", "GroupBox");
                obj = EditorGUIExtension.DragDropAreaSingle(r);
                if (obj != null)
                {
                    objects.Add(obj);
                    serializedObject.ApplyModifiedProperties();
                    serializedObject.Update();
                }

                r = GUILayoutUtility.GetRect(50, 50);
                GUI.Box(r, "ʹ��GUI��ʽ���ƽ��յ�����Դ������ָ��Rect���Զ������ɫ", "GroupBox");
                obj = EditorGUIExtension.DragDropAreaSingle(r, Color.black);
                if (obj != null)
                {
                    objects.Add(obj);
                    serializedObject.ApplyModifiedProperties();
                    serializedObject.Update();
                }

                r = GUILayoutUtility.GetRect(50, 50);
                GUI.Box(r, "ʹ��GUI��ʽ���ƽ��յ�����Դ������ָ��Rect���Զ������ָ��", "GroupBox");
                obj = EditorGUIExtension.DragDropAreaSingle(r, DragAndDropVisualMode.Link);
                if (obj != null)
                {
                    objects.Add(obj);
                    serializedObject.ApplyModifiedProperties();
                    serializedObject.Update();
                }

                r = GUILayoutUtility.GetRect(50, 50);
                GUI.Box(r, "ʹ��GUI��ʽ���ƽ��ն������Դ������ָ��Rect���Զ������ɫ�����ָ��", "GroupBox");
                UnityObject[] objs = EditorGUIExtension.DragDropAreaMulti(r, DragAndDropVisualMode.Link, new Color(0.3f, 0.58f, 0.7f, 0.3f));
                if (objs != null)
                {
                    foreach (var item in objs)
                    {
                        objects.Add(item);
                    }
                    serializedObject.ApplyModifiedProperties();
                    serializedObject.Update();
                }
            }
        }
    }
}
