using UnityEngine;

namespace QFrameworkUml.Editor
{
#if UNITY_EDITOR
    internal class EditorMenus
    {
        [UnityEditor.MenuItem("QFramework/Install QFrameworkWithToolKits")]
        public static void InstallPackageKit()
        {
            Application.OpenURL("https://QFrameworkUml.cn/qf");
        }
    }
#endif
}