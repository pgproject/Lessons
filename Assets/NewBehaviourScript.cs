using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D Rigidbody;

    [SerializeField] private float m_speed;
    [SerializeField] private float m_hight;
    private float m_speedHelp;
    private bool isGround;
    [SerializeField] private float m_moveDown;
    void Awake()
    {
        m_speedHelp = m_speed;
    }

   
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Nacisnałem A");
            if(isGround)
                Rigidbody.MovePosition(Rigidbody.position + Vector2.left * m_speed * Time.fixedDeltaTime);
            else
            {
                Rigidbody.MovePosition(new Vector2(Rigidbody.position.x -1 * m_speed * Time.fixedDeltaTime, Rigidbody.position.y + m_moveDown * Time.fixedDeltaTime));
            }
        }
        if(Input.GetKey(KeyCode.D))
        {
            if (isGround)
                Rigidbody.MovePosition(Rigidbody.position + Vector2.right * m_speed * Time.fixedDeltaTime);

            else
            {
                Rigidbody.MovePosition(new Vector2(Rigidbody.position.x + 1 * m_speed * Time.fixedDeltaTime, Rigidbody.position.y + m_moveDown * Time.fixedDeltaTime));
            }
            Debug.Log("Nacisnałem D");
        }
        if(Input.GetKey(KeyCode.W) && isGround)
        {
            Rigidbody.MovePosition(Rigidbody.position + Vector2.up * m_hight * Time.fixedDeltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name == "Ground")
        {
            isGround = true;
            m_speed = m_speedHelp;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name == "Ground")
        {
            m_speed /= 10;
            isGround = false;
        }
    }
}
