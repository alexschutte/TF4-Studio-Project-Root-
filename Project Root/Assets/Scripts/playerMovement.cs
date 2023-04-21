using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    Vector2 clickPos;
    bool moving;


    // Update is called once per frame
    void Update()
    {
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");

        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, 1f, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0, -1f, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1f, 0, 0);
        }

       /* if (Input.GetMouseButtonDown(0))
        {
            clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        if (moving && (Vector2)transform.position != clickPos)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, clickPos, step);
        }

        else
        {
            moving = false;
        }*/

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

}
