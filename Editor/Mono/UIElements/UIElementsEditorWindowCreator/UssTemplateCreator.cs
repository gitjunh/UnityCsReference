// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System.IO;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    static partial class UIElementsTemplate
    {
        // Add submenu after GUI Skin
        [MenuItem("Assets/Create/UIElements/USS File", false, 603, false)]
        public static void CreateUSSFile()
        {
            var folder = GetCurrentFolder();
            var path = AssetDatabase.GenerateUniqueAssetPath(folder + "/NewUSSFile.uss");
            var contents = "VisualElement {}";
            var icon = EditorGUIUtility.IconContent<StyleSheet>().image as Texture2D;
            ProjectWindowUtil.CreateAssetWithContent(path, contents, icon);
        }
    }
}
