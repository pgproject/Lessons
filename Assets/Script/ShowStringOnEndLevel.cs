using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShowStringOnEndLevel : MonoBehaviour
{
    [SerializeField] private Text m_winText;
    [SerializeField] private float m_waitingTime;

    private void OnTriggerEnter(Collider other)
    {
        m_winText.enabled = true;
        StartCoroutine(WaitWithLoadScene());
    }
    private IEnumerator WaitWithLoadScene()
    {
        yield return new WaitForSeconds(m_waitingTime);
        SceneManager.LoadScene("SampleScene");
    }
}
