using UnityEditor;
using UnityEditor.PackageManager;

namespace UnityFramework.Editor.Package
{
    public partial class UnityEditorTools
    {
        [MenuItem("Assets/SCPackages/HotUpdate/HybridCLR ", false,1)]
        private  static void AddHybridCLRPackage()
        {
       var  addRequest = Client.Add($"https://github.com/focus-creative-games/hybridclr_unity.git");
            if (addRequest.Status== StatusCode.Failure)
            {
            Client.Add($"https://gitee.com/focus-creative-games/hybridclr_unity.git");
            }
        }

    }
}