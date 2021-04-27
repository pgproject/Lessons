using System;
using System.Collections.Generic;
using System.Linq;
using Script.InteractableObject;
using UnityEngine;

public class InteractableMenager : MonoBehaviour
{
    [SerializeField] private PlayerController m_playerController;
    
    private List<IInteractable> m_interactable = new List<IInteractable>();
    
    private void OnTriggerEnter(Collider other)
    {
        IInteractable obj = other.GetComponent<IInteractable>()?.ReturnObject();
        
        if(obj == null) return;
        
        if(!m_interactable.Contains(obj))
            m_interactable.Add(obj);

        m_playerController.InteractableObject = m_interactable[0];
        
        
        Debug.Log(m_interactable.Any());
        Debug.Log(m_interactable[0]);
    }

    private void OnTriggerExit(Collider other)
    {
        IInteractable obj = other.GetComponent<IInteractable>()?.ReturnObject();
        
        if(obj == null) return;

        m_interactable.Remove(obj);

        if (!m_interactable.Any())
            m_playerController.InteractableObject = null;
        else
            m_playerController.InteractableObject = m_interactable[0];

        Debug.Log(m_interactable.Any());
    }
}
