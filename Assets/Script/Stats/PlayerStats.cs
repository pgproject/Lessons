using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[Serializable]
public class PlayerStats
{
    [SerializeField] private int m_hp;

    public int Hp => m_hp;


    [SerializeField] private int m_maxHp;
    
    public int MaxHp
    {
        get;
        set;
    }

    [SerializeField] private int m_damage;
    public int Damage => m_damage;
     
    
    private void OnGUI()
    {
        MaxHp = EditorGUILayout.IntField("Max Hp", MaxHp);
    }
    /*
    [MenuItem("Stats/Player Stats")]
    static void Init()
    {
        PlayerStats window = (PlayerStats) GetWindow(typeof(PlayerStats));
        window.Show();
    }
    private void OnGUI()
    {
        m_maxHp = EditorGUILayout.IntField("Max Hp", m_maxHp);
    }*/
}
