using System.Collections;
using System.Collections.Generic;
using Script.InteractableObject;
using UnityEngine;

public abstract class InteractableObject : MonoBehaviour, IInteractable
{
    public abstract void Interactable();
    public abstract bool CanInteract();
    public IInteractable ReturnObject()
    {
        return this;
    }
}
