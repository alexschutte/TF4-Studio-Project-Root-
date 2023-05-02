using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHitdetection : MonoBehaviour
{
    private Globals global;
    private GameObject PlayerCharacter;
    private GameObject enemyCharacter;

    private void Awake()
    {
        PlayerCharacter = GameObject.FindGameObjectWithTag("Player");
        enemyCharacter = GameObject.FindGameObjectWithTag("enemie");
        global = GameObject.FindGameObjectWithTag("GameController").GetComponent<Globals>();
    }


    // Update is called once per frame
    void Update()
    {
        if(global.shotCheck)
        {
            if (PlayerCharacter.transform.localPosition.y == enemyCharacter.transform.localPosition.y && PlayerCharacter.transform.localPosition.x > enemyCharacter.transform.localPosition.x)
            {
                Destroy(enemyCharacter);
                global.win = true;
                global.shotCheck = false;
            }
            else if (PlayerCharacter.transform.localPosition.y == enemyCharacter.transform.localPosition.y && PlayerCharacter.transform.localPosition.x < enemyCharacter.transform.localPosition.x)
            {
                Destroy(enemyCharacter);
                global.win = true;
                global.shotCheck = false;
            }
            else if (PlayerCharacter.transform.localPosition.x == enemyCharacter.transform.localPosition.x && PlayerCharacter.transform.localPosition.y > enemyCharacter.transform.localPosition.y)
            {
                Destroy(enemyCharacter);
                global.win = true;
                global.shotCheck = false;
            }
            else if (PlayerCharacter.transform.localPosition.x == enemyCharacter.transform.localPosition.x && PlayerCharacter.transform.localPosition.y < enemyCharacter.transform.localPosition.y)
            {
                Destroy(enemyCharacter);
                global.win = true;
                global.shotCheck = false;
            }
            else
            {
                global.shotCheck = false;
            }
        }
    }
}
