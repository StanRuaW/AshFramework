//引用自
//有修改
//作者：马三小伙儿 bilibili id:87410250
//地址：https://github.com/XINCGer/UnityToolchainsTrick
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace EditorEx.SelectAndDropExtend
{
#if UNITY_2019_1_OR_NEWER
    public class AssetReferenceDropdownAssetItem : AdvancedDropdownItem
    {
        public string AssetPath { get; }

        public string FolderPath { get; }

        public AssetReferenceDropdownFolderItem ParentFolder { get; set; }

        public AssetReferenceDropdownAssetItem(string assetPath, string ItemName) : base(ItemName)
        {
            this.AssetPath = assetPath;
            this.FolderPath = Asset.PathUtil.GetAssetDirectoryName(assetPath);
            this.icon = AssetDatabase.GetCachedIcon(assetPath) as Texture2D;
        }
    }
#endif
}