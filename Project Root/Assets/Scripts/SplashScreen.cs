using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{
    public GameObject[] Logos;
    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        /*Logos = GameObject.FindGameObjectsWithTag("Logo");
        foreach (GameObject logo in Logos)
        {
            Image image = logo.GetComponent<Image>();
            Color newColour = image.material.color;
            newColour.a += 10;
            image.material.color = newColour;
        }*/
        StartCoroutine(Wait());
    }
}
