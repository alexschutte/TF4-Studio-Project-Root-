using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickMove : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField] private int tileNo;
    private Vector3 clickPos = new Vector3(-1.5f, -0.26f, -1f);
    private Globals global;
    private GameObject PlayerCharacter;


    private void Awake()
    {
        PlayerCharacter = GameObject.FindGameObjectWithTag("Player");
        global = GameObject.FindGameObjectWithTag("GameController").GetComponent<Globals>();
    }

    void OnMouseOver()
    {
        if (global.playerTurn)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (global.moving && global.AP > 0)
                {
                    if (tileNo == global.playerCurrentPos - 1 || tileNo == global.playerCurrentPos + 1 || tileNo == global.playerCurrentPos - 4 || tileNo == global.playerCurrentPos + 4)
                    {
                        clickPos = transform.position;
                        PlayerCharacter.transform.position = new Vector3(clickPos.x, clickPos.y, -2);
                        global.playerCurrentPos = tileNo;
                        PlayerCharacter.GetComponent<AudioSource>().Play();
                        global.AP--;
                        global.APCounter.text = "AP: " + global.AP;
                    }
                }
            }
        }
    }

    void Update()
    {
        if(tileNo == global.deathCheck1 || tileNo == global.deathCheck2)
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
