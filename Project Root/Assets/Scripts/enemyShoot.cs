using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    private Globals global;
    private GameObject enemyCharacter; 
    private GameObject playerCharacter;

    private void Awake()
    {
        playerCharacter = GameObject.FindGameObjectWithTag("Player");
        enemyCharacter = GameObject.FindGameObjectWithTag("enemie");
        global = GameObject.FindGameObjectWithTag("GameController").GetComponent<Globals>();
    }


    // Update is called once per frame
    void Update()
    {
        if(enemyCharacter.transform.position.y == playerCharacter.transform.position.y && enemyCharacter.transform.position.x > playerCharacter.transform.position.x)
        {
            Debug.Log("pew left");
        }
        if(enemyCharacter.transform.position.y == playerCharacter.transform.position.y && enemyCharacter.transform.position.x < playerCharacter.transform.position.x)
        {
            Debug.Log("pew right");
        }
        if(enemyCharacter.transform.position.x == playerCharacter.transform.position.x && enemyCharacter.transform.position.y > playerCharacter.transform.position.y)
        {
            Debug.Log("pew down");
        }
        if(enemyCharacter.transform.position.x == playerCharacter.transform.position.x && enemyCharacter.transform.position.y < playerCharacter.transform.position.y)
        {
            Debug.Log("pew up");
        }
    }
}
