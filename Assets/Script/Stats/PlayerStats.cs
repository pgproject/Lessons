using System;
using UnityEditor;
using UnityEngine;

namespace Script.Stats
{
    [Serializable, CreateAssetMenu(fileName = "Player Data", menuName = "GeneralStats/PlayerStats", order = 1)]
    public class PlayerStats : ScriptableObject
    {
        [SerializeField] private int m_startHp;
        public int StartHp => m_startHp;
        
        [SerializeField] private int m_hp;
        public int Hp => m_hp;
    
        [SerializeField] private int m_maxHp;
        public int MaxHp => m_maxHp;
    
        [SerializeField] private int m_damage;
        public int Damage => m_damage;
    
        public void OnGUI()
        {
            m_startHp = EditorGUILayout.IntField("Start Hp", m_startHp);
            m_maxHp = EditorGUILayout.IntField("Max Hp", m_maxHp);
            m_hp = EditorGUILayout.IntField("Hp", m_hp);
            m_damage = EditorGUILayout.IntField("Damage", m_damage);
        }

        public void AddHealth(int addHealth)
        {
            m_hp = Mathf.Clamp(m_hp + addHealth, m_hp, m_maxHp);
        }
    }
}
