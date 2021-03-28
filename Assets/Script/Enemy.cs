using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamage
{

    [SerializeField] private int m_hp;
    void Start()
    {
        
    }


    public void Damage(int damage)
    {
        m_hp -= damage;
        
        if(m_hp <= 0)
            Destroy(this.gameObject);
    }
}
