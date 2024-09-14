using UnityEditor;
using UnityEngine;

namespace UnityFramework.Editor.Package
{
    public partial class UnityEditorTools
    {
        [MenuItem("Assets/SCPackages/HotUpdate/YooAsset ", false, 1)]
        private static void AddYooAssetPackage()
        {
            Application.OpenURL($"https://www.yooasset.com/docs/guide-editor/QuickStart");
        }
    }
}

