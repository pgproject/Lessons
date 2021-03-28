using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;
    [SerializeField] private Transform m_playerTransform;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            Instantiate(m_bullet, new Vector3(m_playerTransform.position.x + 1f, m_playerTransform.position.y + 0.5f, m_playerTransform.position.z), m_playerTransform.rotation);
        }
    }
}
