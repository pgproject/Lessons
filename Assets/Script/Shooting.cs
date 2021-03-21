using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;
    [SerializeField] private Transform m_player;
    [SerializeField] private NewBehaviourScript m_controllPlayer;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            Instantiate(m_bullet, new Vector3(m_player.position.x + 1f * (m_controllPlayer.Direction ? -1 : 1), m_player.position.y + 0.5f, m_player.position.z), m_player.rotation);
        }


    }
}
