using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTiles : MonoBehaviour
{
    private Globals global;
    private SpriteRenderer tile1;
    private SpriteRenderer tile2;
    private SpriteRenderer tile3;
    private SpriteRenderer tile4;
    private SpriteRenderer tile5;
    private SpriteRenderer tile6;
    private SpriteRenderer tile7;
    private SpriteRenderer tile8;
    private SpriteRenderer tile9;
    private SpriteRenderer tile10;
    private SpriteRenderer tile11;
    private SpriteRenderer tile12;
    private SpriteRenderer tile13;
    private SpriteRenderer tile14;

    private void Awake()
    {
        global = GameObject.FindGameObjectWithTag("GameController").GetComponent<Globals>();
        tile1 = transform.Find("MoveTile (1)").GetComponent<SpriteRenderer>();
        tile2 = transform.Find("MoveTile (2)").GetComponent<SpriteRenderer>();
        tile3 = transform.Find("MoveTile (3)").GetComponent<SpriteRenderer>();
        tile4 = transform.Find("MoveTile (4)").GetComponent<SpriteRenderer>();
        tile5 = transform.Find("MoveTile (5)").GetComponent<SpriteRenderer>();
        tile6 = transform.Find("MoveTile (6)").GetComponent<SpriteRenderer>();
        tile7 = transform.Find("MoveTile (7)").GetComponent<SpriteRenderer>();
        tile8 = transform.Find("MoveTile (8)").GetComponent<SpriteRenderer>();
        tile9 = transform.Find("MoveTile (9)").GetComponent<SpriteRenderer>();
        tile10 = transform.Find("MoveTile (10)").GetComponent<SpriteRenderer>();
        tile11 = transform.Find("MoveTile (11)").GetComponent<SpriteRenderer>();
        tile12 = transform.Find("MoveTile (12)").GetComponent<SpriteRenderer>();
        tile13 = transform.Find("MoveTile (13)").GetComponent<SpriteRenderer>();
        tile14 = transform.Find("MoveTile (14)").GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (global.playerCurrentPos <= 4)
        {
            tile1.enabled = false;
        }
        else
        {
            tile1.enabled = true;
        }

        if (global.playerCurrentPos % 4 == 0)
        {
            tile2.enabled = false;
        }
        else
        {
            tile2.enabled = true;
        }

        if (global.playerCurrentPos >= 17)
        {
            tile3.enabled = false;
        }
        else
        {
            tile3.enabled = true;
        }

        if (global.playerCurrentPos % 4 == 1)
        {
            tile4.enabled = false;
        }
        else
        {
            tile4.enabled = true;
        }
    }
}
