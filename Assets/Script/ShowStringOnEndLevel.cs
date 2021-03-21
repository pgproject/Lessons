using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShowStringOnEndLevel : MonoBehaviour
{
    public Text WinText;
    public float TimeToWait;

    private void OnTriggerEnter(Collider other)
    {
        WinText.enabled = true;
        StartCoroutine(WaitForWin());
    }
    private IEnumerator WaitForWin()
    {
        yield return new WaitForSeconds(TimeToWait);
        SceneManager.LoadScene("SampleScene");
    }
}
