using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlantObject : InteractableObject
{
    [SerializeField] private string m_sceneToLoad;
    public override void Interactable()
    {
        Debug.Log("1234");
        if (CanInteract())
            SceneManager.LoadSceneAsync(m_sceneToLoad);
    }

    public override bool CanInteract()
    {
        return true;
    }
}
