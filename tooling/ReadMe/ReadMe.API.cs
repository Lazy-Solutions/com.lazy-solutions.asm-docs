using System.Linq;
using UnityEditor;
using UnityEngine;

namespace AdvancedSceneManager.Documentation
{

    partial class ReadMe
    {

        /// <summary>Attempts to find the readme instance in the docs folder.</summary>
        public static ReadMe FindInstance()
        {

            var readmes = AssetDatabase.FindAssets("t:" + typeof(ReadMe).FullName, new[] { Package.folder }).
                Select(AssetDatabase.GUIDToAssetPath).
                Select(AssetDatabase.LoadAssetAtPath<ReadMe>).
                OfType<ReadMe>();

            return readmes.FirstOrDefault();

        }

        /// <summary>Attempts to find and view the readme in the project explorer.</summary>
        public static void ViewInProjectExplorer()
        {

            var obj = FindInstance();
            if (obj)
                EditorGUIUtility.PingObject(obj);
            else
                EditorGUIUtility.PingObject(AssetDatabase.LoadAssetAtPath<Object>(Package.folder));

        }

    }

}
