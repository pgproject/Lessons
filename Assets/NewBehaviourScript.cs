using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody Rigidbody;

    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Nacisnałem A");
        }
        if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("Nacisnałem D");
        }
    }
}
