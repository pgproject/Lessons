using Script.InteractableObject;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody m_rigidbody;
    
    public float Speed;
    public float HeigthOfJump;
    public float SpeedInAir;

    private float m_speedHelp;
    private bool m_isGround;
    [SerializeField] private PlayerInput m_inputAction;


    private bool m_InteractWithButton
    {
        get
        {
            if (InteractableObject != null)
                return InteractableObject.InteractWithButton();
            
            return false;
        }
        
    }
    public IInteractable InteractableObject { get; set; }
    
    void Start()
    {
        m_speedHelp = Speed;
    }
   
    void Update()
    {
        if(m_inputAction.currentActionMap["MoveLeft"].ReadValue<float>() > 0)
        {
            m_rigidbody.MovePosition(m_rigidbody.transform.position + Vector3.left * Speed);
        }
        if(m_inputAction.currentActionMap["MoveRight"].ReadValue<float>() > 0)
        {
            m_rigidbody.MovePosition(m_rigidbody.transform.position + Vector3.right * Speed);
        }
        if(m_inputAction.currentActionMap["Jump"].triggered && m_isGround)
        {
            m_rigidbody.MovePosition(m_rigidbody.transform.position + Vector3.up * HeigthOfJump);
        }
        if (m_inputAction.currentActionMap["Interact"].triggered && m_InteractWithButton)
        {
            InteractableObject?.Interact();
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
}
