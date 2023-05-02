using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{

    private Globals global;
    private GameObject enemyCharacter;
    private GameObject playerCharacter;
    private GameObject laserPivot;
    private GameObject laser;
    private int ranNum;

    private void Awake()
    {
        playerCharacter = GameObject.FindGameObjectWithTag("Player");
        enemyCharacter = GameObject.FindGameObjectWithTag("enemie");
        global = GameObject.FindGameObjectWithTag("GameController").GetComponent<Globals>();
        laserPivot = GameObject.Find("LaserPivotE1");
        laser = GameObject.Find("LaserE1");
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
            if (global.enemyAP > 0)
            {
                if (enemyCharacter.transform.localPosition.y == playerCharacter.transform.localPosition.y && enemyCharacter.transform.localPosition.x > playerCharacter.transform.localPosition.x)
                {
                    laserPivot.transform.rotation = Quaternion.Euler(0, 0, 90);
                    laser.GetComponent<Animator>().Play("laserShoot");
                    Destroy(playerCharacter);
                }
                else if (enemyCharacter.transform.localPosition.y == playerCharacter.transform.localPosition.y && enemyCharacter.transform.localPosition.x < playerCharacter.transform.localPosition.x)
                {
                    laserPivot.transform.rotation = Quaternion.Euler(0, 0, -90);
                    laser.GetComponent<Animator>().Play("laserShoot");
                    Destroy(playerCharacter);
                }
                else if (enemyCharacter.transform.localPosition.x == playerCharacter.transform.localPosition.x && enemyCharacter.transform.localPosition.y > playerCharacter.transform.localPosition.y)
                {
                    laserPivot.transform.rotation = Quaternion.Euler(0, 0, 180);
                    laser.GetComponent<Animator>().Play("laserShoot");
                    Destroy(playerCharacter);
                }
                else if (enemyCharacter.transform.localPosition.x == playerCharacter.transform.localPosition.x && enemyCharacter.transform.localPosition.y < playerCharacter.transform.localPosition.y)
                {
                    laserPivot.transform.rotation = Quaternion.Euler(0, 0, 0);
                    laser.GetComponent<Animator>().Play("laserShoot");
                    Destroy(playerCharacter);
                }
                else
                {
                    NewRandomNumber();
                    if (ranNum == 1)
                    {
                        if (global.enemyCurrentPos < 5)
                        {
                            NewRandomNumber();
                        }
                        else
                        {
                            enemyCharacter.transform.position = new Vector3(enemyCharacter.transform.position.x, enemyCharacter.transform.position.y + 1, enemyCharacter.transform.position.z);
                            global.enemyCurrentPos = global.enemyCurrentPos - 4;
                            global.enemyAP--;
                        }
                    }
                    else if (ranNum == 2)
                    {
                        if (global.enemyCurrentPos == 4 || global.enemyCurrentPos == 8 || global.enemyCurrentPos == 12 || global.enemyCurrentPos == 16 || global.enemyCurrentPos == 20)
                        {
                            NewRandomNumber();
                        }
                        else
                        {
                            enemyCharacter.transform.position = new Vector3(enemyCharacter.transform.position.x + 1, enemyCharacter.transform.position.y, enemyCharacter.transform.position.z);
                            global.enemyCurrentPos = global.enemyCurrentPos + 1;
                            global.enemyAP--;
                        }
                    }
                    else if (ranNum == 3)
                    {
                        if (global.enemyCurrentPos > 16)
                        {
                            NewRandomNumber();
                        }
                        else
                        {
                            enemyCharacter.transform.position = new Vector3(enemyCharacter.transform.position.x, enemyCharacter.transform.position.y - 1, enemyCharacter.transform.position.z);
                            global.enemyCurrentPos = global.enemyCurrentPos + 4;
                            global.enemyAP--;
                        }
                    }
                    else if (ranNum == 4)
                    {
                        if (global.enemyCurrentPos == 1 || global.enemyCurrentPos == 5 || global.enemyCurrentPos == 9 || global.enemyCurrentPos == 13 || global.enemyCurrentPos == 17)
                        {
                            NewRandomNumber();
                        }
                        else
                        {
                            enemyCharacter.transform.position = new Vector3(enemyCharacter.transform.position.x - 1, enemyCharacter.transform.position.y, enemyCharacter.transform.position.z);
                            global.enemyCurrentPos = global.enemyCurrentPos - 1;
                            global.enemyAP--;
                        }
                    }
                }
                
            }
            global.playerTurn = true;
            global.enemyAP++;
        }
    }
}
