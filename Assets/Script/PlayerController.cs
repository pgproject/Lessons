using System;
using System.Collections;
using System.Collections.Generic;
using Script.InteractableObject;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float Speed;
    public float HeigthOfJump;
    public float SpeedInAir;

    private float m_speedHelp;
    private bool m_isGround;
    [SerializeField] private PlayerInput m_inputAction;

    public IInteractable InteractableObject { get; set; }
    
    void Start()
    {
        m_speedHelp = Speed;
    }
   
    void Update()
    {
        if(m_inputAction.currentActionMap["MoveLeft"].ReadValue<float>() > 0)
        {
            Rigidbody.MovePosition(Rigidbody.transform.position + Vector3.left * Speed);
        }
        if(m_inputAction.currentActionMap["MoveRight"].ReadValue<float>() > 0)
        {
            Rigidbody.MovePosition(Rigidbody.transform.position + Vector3.right * Speed);
        }
        if(m_inputAction.currentActionMap["Jump"].triggered && m_isGround)
        {
            Rigidbody.MovePosition(Rigidbody.transform.position + Vector3.up * HeigthOfJump);
        }
        if (m_inputAction.currentActionMap["Interact"].triggered)
        {
            Debug.Log(InteractableObject);
            InteractableObject?.Interactable();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Ground")
        {
            Speed = m_speedHelp;
            m_isGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.collider.name == "Ground")
        {
            Speed /= SpeedInAir;
            m_isGround = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IInteractable>() != null)
        {
            
        }
    }
}
