using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void StartGame()
    {
        StartCoroutine(WaitForStartAnim());
    }

    IEnumerator WaitForStartAnim()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene(2);
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene(1);
    }
}
