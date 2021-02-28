using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody Rigidbody;

    [SerializeField] private float m_speed;
    [SerializeField] private float m_hight;

    private bool isGround;
    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Nacisnałem A");

            Rigidbody.MovePosition(Rigidbody.transform.position + Vector3.left * m_speed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            Rigidbody.MovePosition(Rigidbody.transform.position + Vector3.right * m_speed);

            Debug.Log("Nacisnałem D");
        }
        if(Input.GetKey(KeyCode.W) && isGround)
        {
            Rigidbody.MovePosition(Rigidbody.transform.position + Vector3.up * m_hight);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.name== "Ground")
        {
            isGround = true;
            Debug.Log("1234");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.name == "Ground")
        {
            isGround = false;
        }
    }
}
