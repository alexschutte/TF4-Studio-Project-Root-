using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enemyMove2 : MonoBehaviour
{
    private Globals global;
    private GameObject playerCharacter;
    private GameObject laserPivot;
    private GameObject laser;
    private int ranNum;

    private void Awake()
    {
        playerCharacter = GameObject.FindGameObjectWithTag("Player");
        global = GameObject.FindGameObjectWithTag("GameController").GetComponent<Globals>();
        laserPivot = GameObject.Find("LaserPivotE2");
        laser = GameObject.Find("LaserE2");
        NewRandomNumber();
    }

    void NewRandomNumber()
    {
        ranNum = Random.Range(1, 5);
    }

    void Update()
    {
        if (!global.playerTurn)
        {
            while (global.enemy2AP > 0)
            {
                if (transform.localPosition.y == playerCharacter.transform.localPosition.y && transform.localPosition.x > playerCharacter.transform.localPosition.x)
                {
                    laserPivot.transform.rotation = Quaternion.Euler(0, 0, 90);
                    laser.GetComponent<Animator>().Play("laserShoot");
                    laser.GetComponent<AudioSource>().Play();
                    laserPivot.GetComponent<AudioSource>().Play();
                    StartCoroutine(WaitForLaser());
                    Destroy(playerCharacter);
                }
                else if (transform.localPosition.y == playerCharacter.transform.localPosition.y && transform.localPosition.x < playerCharacter.transform.localPosition.x)
                {
                    laserPivot.transform.rotation = Quaternion.Euler(0, 0, -90);
                    laser.GetComponent<Animator>().Play("laserShoot");
                    laser.GetComponent<AudioSource>().Play();
                    laserPivot.GetComponent<AudioSource>().Play();
                    StartCoroutine(WaitForLaser());
                    Destroy(playerCharacter);
                }
                else if (transform.localPosition.x == playerCharacter.transform.localPosition.x && transform.localPosition.y > playerCharacter.transform.localPosition.y)
                {
                    laserPivot.transform.rotation = Quaternion.Euler(0, 0, 180);
                    laser.GetComponent<Animator>().Play("laserShoot");
                    laser.GetComponent<AudioSource>().Play();
                    laserPivot.GetComponent<AudioSource>().Play();
                    StartCoroutine(WaitForLaser());
                    Destroy(playerCharacter);
                }
                else if (transform.localPosition.x == playerCharacter.transform.localPosition.x && transform.localPosition.y < playerCharacter.transform.localPosition.y)
                {
                    laserPivot.transform.rotation = Quaternion.Euler(0, 0, 0);
                    laser.GetComponent<Animator>().Play("laserShoot");
                    laser.GetComponent<AudioSource>().Play();
                    laserPivot.GetComponent<AudioSource>().Play();
                    StartCoroutine(WaitForLaser());
                    Destroy(playerCharacter);
                }
                else
                {
                    Move();
                }
                global.enemy2AP--;
            }
            global.enemy2AP = 1;
            GameObject.Find("APCounterE1").GetComponent<TextMeshPro>().text = global.enemy2AP.ToString();
        }
    }
    private void Move()
    {
        NewRandomNumber();
        if (ranNum == 1)
        {
            if (global.enemy2CurrentPos < 5)
            {
                Move();
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
                global.enemy2CurrentPos = global.enemy2CurrentPos - 4;
            }
        }
        else if (ranNum == 2)
        {
            if (global.enemy2CurrentPos == 4 || global.enemy2CurrentPos == 8 || global.enemy2CurrentPos == 12 || global.enemy2CurrentPos == 16 || global.enemy2CurrentPos == 20)
            {
                Move();
            }
            else
            {
                transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
                global.enemy2CurrentPos = global.enemy2CurrentPos + 1;
            }
        }
        else if (ranNum == 3)
        {
            if (global.enemy2CurrentPos > 16)
            {
                Move();
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
                global.enemy2CurrentPos = global.enemy2CurrentPos + 4;
            }
        }
        else if (ranNum == 4)
        {
            if (global.enemy2CurrentPos == 1 || global.enemy2CurrentPos == 5 || global.enemy2CurrentPos == 9 || global.enemy2CurrentPos == 13 || global.enemy2CurrentPos == 17)
            {
                Move();
            }
            else
            {
                transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
                global.enemy2CurrentPos = global.enemy2CurrentPos - 1;
            }
        }
    }

    IEnumerator WaitForLaser()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        global.lose = true;
    }
}
