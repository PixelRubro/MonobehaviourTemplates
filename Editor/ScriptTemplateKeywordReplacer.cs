using UnityEditor;
using System.IO;

namespace SoftBoiledGames.MonobehaviourTemplates
{
    /// <summary>
    /// Author: Alexey Demonov
    /// </summary>
    public class ScriptTemplateKeywordReplacer : UnityEditor.AssetModificationProcessor
    {
        // If there would be more than one keyword to replace, add a Dictionary.
        public static void OnWillCreateAsset(string metaFilePath)
        {
            string fileName = Path.GetFileNameWithoutExtension(metaFilePath);

            if (!fileName.EndsWith(".cs"))
            {
                return;
            }

            string actualFilePath = $"{Path.GetDirectoryName(metaFilePath)}{Path.DirectorySeparatorChar}{fileName}";
            string content = File.ReadAllText(actualFilePath);
            string newcontent = content.Replace("#PROJECTNAME#", $"{PlayerSettings.companyName}.{PlayerSettings.productName}");

            if (content != newcontent)
            {
                File.WriteAllText(actualFilePath, newcontent);
                AssetDatabase.Refresh();
            }
        }
    }
}