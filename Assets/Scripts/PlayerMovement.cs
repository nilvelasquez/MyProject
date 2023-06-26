using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    private float speed = 1f;
    public Rigidbody2D rb;
    private BoxCollider2D box;
    private Vector2 movement;
    private Vector2 movement2;
    private bool up = false;
    private bool down = false;
    private bool left = false;
    private bool right = false;
   protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();    
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        movement = new Vector2(moveHorizontal, moveVertical);
    }
    void FixedUpdate()
    {
        if (up)
        {
            movement2 = new Vector2(0f, 1f);
            movement = movement2;
        }
        if (right)
        {
            movement2 = new Vector2(1f, 0f);
            movement = movement2;
        }
        if (left)
        {
            movement2 = new Vector2(-1f, 0f);
            movement = movement2;
        }
        if (down)
        {
            movement2 = new Vector2(0f, -1f);
            movement = movement2;
        }
        rb.velocity = movement * speed;
    }
    public void MoveUp()
    {
        up = true;        
    }
    public void MoveUpsoltar()
    {
        up = false;
    }
    public void MoveDown()
    {
        down = true;
    }
    public void MoveDownSoltar()
    {
        down = false;
    }
    public void MoveLeft()
    {
        left = true;
    }
    public void MoveLeftSoltar()
    {
        left = false;
    }
    public void MoveRight()
    {
        right = true;
    }
    public void MoveRightSoltar()
    {
        right = false;
    }
}