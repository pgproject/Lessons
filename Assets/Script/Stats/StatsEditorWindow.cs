using System;
using Script.Stats;
using UnityEditor;
using UnityEngine;

public class StatsEditorWindow : EditorWindow
{
    [MenuItem("Stats/Player Stats")]
    static void Init()
    {
        StatsEditorWindow window = (StatsEditorWindow)GetWindow(typeof(StatsEditorWindow));
        window.Show();
    }
   
    private void OnValidate()
    {
        GeneralStats.Instance.CreateInstance();
    }

    private void OnGUI()
    {
        GUILayout.Label("Player Stats", EditorStyles.boldLabel);
        GeneralStats.Instance.PlayerStats.OnGUI();
    }
}
