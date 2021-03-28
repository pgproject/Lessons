using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody m_rigidbody;
    [SerializeField] private float m_speed;
    [SerializeField] private float m_distanceToDestroy;
    [SerializeField] private float m_timeToDestroy;
    [SerializeField] private int m_danage;

    private float m_distanceTraveled;
    void Update()
    {
        m_rigidbody.MovePosition(new Vector3(transform.position.x + m_speed, transform.position.y, transform.position.z));
        m_distanceTraveled += m_speed;
        if (m_distanceToDestroy <= m_distanceTraveled)
            Destroy(this.gameObject);
    }


    IEnumerator DestroyObjectAfterTime()
    {
        yield return new WaitForSeconds(m_timeToDestroy);

    }

    private void OnCollisionEnter(Collision other)
    {
       other.gameObject.GetComponent<IDamage>()?.Damage(m_danage);
    }
}
