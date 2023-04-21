using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickMove : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField]private Transform player;
    Vector2 clickPos;
    bool moving;


    private void Update()
    {
        OnMouseEnter();
    }


    void OnMouseEnter()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click");
            clickPos = transform.position;
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
        }
    }
}
