using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Globals : MonoBehaviour
{
    public int playerCurrentPos;
    public int enemy1CurrentPos;
    public int AP;
    public int turn;
    public int enemy1AP;
    [SerializeField] public Text APCounter;
    [SerializeField] public Text turnCounter;
    public bool moving;
    public bool playerTurn;
    public bool shotCheck;

    private void Awake()
    {
        playerCurrentPos = 17;
        AP = 5;
        turn = 1;
        APCounter.text = "AP: " + AP.ToString();
        turnCounter.text = "Turn " + turn.ToString();
        moving = true;
        enemy1CurrentPos = 4;
        enemy1AP = 1;
        playerTurn = true;
        shotCheck = false;
    }
}
