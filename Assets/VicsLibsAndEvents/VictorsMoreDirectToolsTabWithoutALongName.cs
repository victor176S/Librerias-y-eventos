using UnityEditor;
using UnityEngine;

public class VictorsMoreDirectToolsTabWithoutALongName : EditorWindow
{
    [MenuItem("Vic´sTools/Easier Access")]
    private static void Init()
    {
        var inspWndType = typeof(SceneView);
        var window = GetWindow<VictorsMoreDirectToolsTabWithoutALongName>(inspWndType);
    }

    private void OnGUI()
    {
        EditorGUILayout.LabelField("Easier Access Buttons WIP", EditorStyles.boldLabel);

        if (GUILayout.Button("Convert Render Shaders/Solve Pink Texture"))
        {
            
        }
    }
}