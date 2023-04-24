using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickShoot : MonoBehaviour
{
    private Globals global;
    private GameObject laserPivot;
    private GameObject laser;
    private GameObject tile1;
    private GameObject tile20;
    [SerializeField] private int tileNo;

    private void Awake()
    {
        global = GameObject.FindGameObjectWithTag("GameController").GetComponent<Globals>();
        laserPivot = GameObject.Find("LaserPivot");
        laser = GameObject.Find("Laser");
        tile1 = GameObject.Find("Tile (1)");
        tile20 = GameObject.Find("Tile (20)");
    }

    private void Update()
    {
        if (!global.moving)
        {
            GetComponent<BoxCollider>().enabled = true;
        }
        else
        {
            GetComponent<BoxCollider>().enabled = false;
        }

        // hide if out of area
        if (transform.position.x < tile1.transform.position.x - 0.05 || transform.position.x > tile20.transform.position.x + 0.05 ||
            transform.position.y < tile20.transform.position.y - 0.05 || transform.position.y > tile1.transform.position.y + 0.05)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<BoxCollider>().enabled = true;
        }

        if (global.moving && tileNo > 4)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!global.moving && global.AP > 0)
            {
                if (transform.localPosition.y > 0)
                {
                    laserPivot.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else if (transform.localPosition.y < 0)
                {
                    laserPivot.transform.rotation = Quaternion.Euler(0, 0, 180);
                }
                else if (transform.localPosition.x > 0)
                {
                    laserPivot.transform.rotation = Quaternion.Euler(0, 0, -90);
                }
                else if (transform.localPosition.x < 0)
                {
                    laserPivot.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                laser.GetComponent<Animator>().Play("laserShoot");
                global.AP--;
                global.APCounter.text = "AP: " + global.AP;
            }
        }
    }
}