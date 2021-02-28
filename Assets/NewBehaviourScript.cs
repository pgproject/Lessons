using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float Speed;
    public float HeigthOfJump;
    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Nacisnałem A");
            Rigidbody.MovePosition(Rigidbody.transform.position + Vector3.left * Speed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("Nacisnałem D");
            Rigidbody.MovePosition(Rigidbody.transform.position + Vector3.right * Speed);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            Rigidbody.MovePosition(Rigidbody.transform.position + Vector3.up * HeigthOfJump);
            Debug.Log("Odcisnałem W");
        }
    }
}
