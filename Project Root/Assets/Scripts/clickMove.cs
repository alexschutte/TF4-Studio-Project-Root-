using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickMove : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField] private int tileNo;
    Vector3 clickPos = new Vector3(-1.5f, -0.28f, -1f);
    private Globals global;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject PlayerCharacter = GameObject.FindGameObjectWithTag("Player");
            global = GameObject.FindGameObjectWithTag("GameController").GetComponent<Globals>();

            if (global.moving && global.AP > 0)
            {
                if (tileNo == global.playerCurrentPos - 1 || tileNo == global.playerCurrentPos + 1 || tileNo == global.playerCurrentPos - 4 || tileNo == global.playerCurrentPos + 4)
                {
                    clickPos = transform.position;
                    PlayerCharacter.transform.position = new Vector3(clickPos.x, clickPos.y, -2);
                    global.playerCurrentPos = tileNo;
                    global.AP--;
                    global.APCounter.text = "AP: " + global.AP;
                }
            }
              
        }
    }
}
