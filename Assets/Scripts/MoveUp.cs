using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Circle.Unit;

public class MoveUp : MonoBehaviour
{
    Rigidbody2D rb;
    private bool moveUp;
    private float move;
    public float speed = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveUp = false;
    }

    public void PoinerUp()
    {
        moveUp = false;
    }

    public void PointerDown()
    {
        moveUp = true;
    }

    void Update()
    {
        
        MovementPlayer();
    }

    private void MovementPlayer()
    {
        if (moveUp)
        {
            move = speed;
        }
        else
        {
            move = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, move);
    }

}
