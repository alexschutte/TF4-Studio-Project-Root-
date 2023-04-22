using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Globals : MonoBehaviour
{
    public int playerCurrentPos;
    public int AP;
    public int turn;
    [SerializeField] public Text APCounter;
    [SerializeField] public Text turnCounter;
    public bool moving;

    private void Awake()
    {
        playerCurrentPos = 17;
        AP = 5;
        turn = 1;
        APCounter.text = "AP: " + AP.ToString();
        turnCounter.text = "Turn " + turn.ToString();
        moving = true;
    }
}
