using System.Collections;
using System.Collections.Generic;
using Script.Stats;
using UnityEngine;

public class HealthPack : InteractableObject
{
    [SerializeField] private int m_addHealth;
    public override void Interact()
    {
        if (GeneralStats.Instance.PlayerStats.Hp < GeneralStats.Instance.PlayerStats.MaxHp)
        {        
            GeneralStats.Instance.PlayerStats.AddHealth(m_addHealth);
            Destroy(this.transform.parent.gameObject);
        }
    }

    public override bool CanInteract()
    {
        return true;
    }

    public override bool InteractWithButton()
    {
        return false;
    }
}
