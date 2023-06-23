using UnityEngine;

namespace QFramework.Editor
{
#if UNITY_EDITOR
    internal class EditorMenus
    {
        [UnityEditor.MenuItem("QFramework/Install QFrameworkWithToolKits")]
        public static void InstallPackageKit()
        {
            Application.OpenURL("https://qframework.cn/qf");
        }
    }
#endif
}