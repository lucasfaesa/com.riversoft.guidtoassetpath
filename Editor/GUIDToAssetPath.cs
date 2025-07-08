#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace RiverSoft.Editor
{
    public class GUIDToAssetPath : EditorWindow
    {
        private const int WINDOW_WIDTH = 400;
        private const int WINDOW_HEIGHT = 120;
        private const int BUTTON_WIDTH = 120;
        private const string NOT_FOUND_MESSAGE = "Asset not found";
    
        private string guidInput = "";
        private string assetPathResult = "";
    
        [MenuItem("RiverSoft/Tools/GUIDToAssetPath")]
        static void CreateWindow()
        {
            GUIDToAssetPath window = (GUIDToAssetPath)EditorWindow.GetWindowWithRect(
                typeof(GUIDToAssetPath), 
                new Rect(0, 0, WINDOW_WIDTH, WINDOW_HEIGHT)
            );
        }
    
        void OnGUI()
        {
            DrawGuidInputField();
            DrawGetAssetPathButton();
            DrawAbortButton();
            DrawResultLabel();
        }
    
        private void DrawGuidInputField()
        {
            GUILayout.Label("Enter GUID:");
            guidInput = GUILayout.TextField(guidInput);
        }
    
        private void DrawGetAssetPathButton()
        {
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Get Asset Path", GUILayout.Width(BUTTON_WIDTH)))
            {
                assetPathResult = ConvertGuidToAssetPath(guidInput);
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }
    
        private void DrawAbortButton()
        {
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Close", GUILayout.Width(BUTTON_WIDTH)))
            {
                Close();
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }
    
        private void DrawResultLabel()
        {
            GUILayout.Label(assetPathResult);
        }
    
        private static string ConvertGuidToAssetPath(string guid)
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(guid);
            Debug.Log($"Asset path for GUID '{guid}': {assetPath}");
        
            return string.IsNullOrEmpty(assetPath) ? NOT_FOUND_MESSAGE : assetPath;
        }
    }
}
#endif