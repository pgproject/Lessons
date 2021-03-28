using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody m_rigidbody;
    [SerializeField] private float m_speed;

    [SerializeField] private float m_distacnceToDestroy;

    private float m_distanceTraveled;

    void Update()
    {
        m_rigidbody.MovePosition(new Vector3(transform.position.x + m_speed, transform.position.y, transform.position.z));

        m_distanceTraveled += m_speed;


    }
}
