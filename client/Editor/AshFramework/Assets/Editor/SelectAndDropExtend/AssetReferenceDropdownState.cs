//引用自
//有修改
//作者：马三小伙儿 bilibili id:87410250
//地址：https://github.com/XINCGer/UnityToolchainsTrick
using System;
using UnityEditor;
using UnityEditor.IMGUI.Controls;

namespace EditorEx.SelectAndDropExtend
{
#if UNITY_2019_1_OR_NEWER
    public class AssetReferenceDropdownState : AdvancedDropdownState
    {
        public SerializedProperty Property { get; }
        public Type AssetType { get; }

        public AssetReferenceDropdownState(Type assetType, SerializedProperty property) : base()
        {
            this.Property = property;
            this.AssetType = assetType;
        }
    }
#endif
}