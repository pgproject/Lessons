using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float Speed;
    public float HeigthOfJump;
    public float SpeedInAir;

    private float m_speedHelp;
    private bool m_isGround;
    

    void Start()
    {
        m_speedHelp = Speed;
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
        if(Input.GetKeyDown(KeyCode.Space) && m_isGround)
        {
            Rigidbody.MovePosition(Rigidbody.transform.position + Vector3.up * HeigthOfJump);
            Debug.Log("Odcisnałem W");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Ground")
        {
            Speed = m_speedHelp;
            m_isGround = true;
            Debug.Log("Spadłem na ziemię");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.collider.name == "Ground")
        {
            Speed /= SpeedInAir;
            m_isGround = false;
            Debug.Log("Skoczyłem");
        }
    }
}
