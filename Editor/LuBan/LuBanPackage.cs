using UnityEditor;
using UnityEditor.PackageManager;

namespace UnityFramework.Editor.Package
{
    public partial class UnityEditorTools
    {
        [MenuItem("Assets/SCPackages/Data/LuBan_Unity ",false,1)]
        private  static void AddLuBanPackage()
        {
       var  addRequest = Client.Add($"https://github.com/focus-creative-games/luban_unity.git");
            if (addRequest.Status== StatusCode.Failure)
            {
            Client.Add($"https://gitee.com/focus-creative-games/luban_unity.git");
            }
        }

    }
}