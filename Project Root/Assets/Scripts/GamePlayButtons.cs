using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayButtons : MonoBehaviour
{
    private Globals global;

    private void Awake()
    {
        global = GameObject.FindGameObjectWithTag("GameController").GetComponent<Globals>();
    }

    public void Root()
    {
        global.AP++;
        global.APCounter.text = "AP: " + global.AP;
    }

    public void MoveFire()
    {
        if (global.moving)
        {
            global.moving = false;
            GetComponentInChildren<Text>().text = "FIRE";

        }
        else
        {
            global.moving = true;
            GetComponentInChildren<Text>().text = "JUMP";
        }
    }
    public void Back()
    {
        SceneManager.LoadScene(1);
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
