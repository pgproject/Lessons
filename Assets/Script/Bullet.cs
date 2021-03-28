using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody m_rigidbody;
    [SerializeField] private float m_speed;

    [SerializeField] private float m_time;
    [SerializeField] private int m_damage;
    private void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    void Update()
    {
        m_rigidbody.MovePosition(new Vector3(transform.position.x + m_speed, transform.position.y, transform.position.z));
    }

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(m_time);
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<IDamage>()?.Damage(m_damage);
    }
}
