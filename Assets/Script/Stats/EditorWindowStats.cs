using UnityEditor;
using UnityEngine;

public class EditorWindowStats : EditorWindow
{

    [SerializeField] private PlayerStats m_playerStats = new PlayerStats();
    
    [MenuItem("Stats/Player Stats")]
    static void Init()
    {
        EditorWindowStats window = (EditorWindowStats) GetWindow(typeof(EditorWindowStats));
        window.Show();
    }
    
    
}
