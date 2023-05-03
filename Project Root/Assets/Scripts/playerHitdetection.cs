using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHitdetection : MonoBehaviour
{
    private Globals global;
    private GameObject PlayerCharacter;
    private GameObject enemyCharacter1;

    private void Awake()
    {
        PlayerCharacter = GameObject.FindGameObjectWithTag("Player");
        enemyCharacter1 = GameObject.Find("Enemy1");
        global = GameObject.FindGameObjectWithTag("GameController").GetComponent<Globals>();
    }


    // Update is called once per frame
    void Update()
    {
        if(global.shotCheck)
        {
            if (PlayerCharacter.transform.localPosition.y == enemyCharacter1.transform.localPosition.y && PlayerCharacter.transform.localPosition.x > enemyCharacter1.transform.localPosition.x)
            {
                Destroy(enemyCharacter1);
                enemyCharacter1.GetComponent<AudioSource>().Play();
                StartCoroutine(WaitForLaser());
                global.shotCheck = false;
            }
            else if (PlayerCharacter.transform.localPosition.y == enemyCharacter1.transform.localPosition.y && PlayerCharacter.transform.localPosition.x < enemyCharacter1.transform.localPosition.x)
            {
                Destroy(enemyCharacter1);
                enemyCharacter1.GetComponent<AudioSource>().Play();
                StartCoroutine(WaitForLaser());
                global.shotCheck = false;
            }
            else if (PlayerCharacter.transform.localPosition.x == enemyCharacter1.transform.localPosition.x && PlayerCharacter.transform.localPosition.y > enemyCharacter1.transform.localPosition.y)
            {
                Destroy(enemyCharacter1);
                enemyCharacter1.GetComponent<AudioSource>().Play();
                StartCoroutine(WaitForLaser());
                global.shotCheck = false;
            }
            else if (PlayerCharacter.transform.localPosition.x == enemyCharacter1.transform.localPosition.x && PlayerCharacter.transform.localPosition.y < enemyCharacter1.transform.localPosition.y)
            {
                Destroy(enemyCharacter1);
                enemyCharacter1.GetComponent<AudioSource>().Play();
                StartCoroutine(WaitForLaser());
                global.shotCheck = false;
            }
            else
            {
                global.shotCheck = false;
            }
        }
    }

    IEnumerator WaitForLaser()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        global.win = true;
    }
}
