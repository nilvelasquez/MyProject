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
    private bool up;
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
        //Debug.Log(moveHorizontal);
        if ((movement2.x != 0) || (movement2.y != 0))
        {
            Debug.Log("pulsada " + movement2);
            movement = movement2;
            movement2 = new Vector2(0f, 0f);           
        }
    }
    void FixedUpdate()
    {
        rb.velocity = movement * speed;
    }
    public void MoveUp()
    {
        movement2 = new Vector2(0f, 5f);
        //rb.velocity = movement2 * speed;
    }
    public void MoveUpStop()
    {
        movement2 = new Vector2(0f, 0f);
    }
    public void MoveDown()
    {
        Debug.Log("D");
        movement2 = new Vector2(0f, -5f);
        //rb.velocity = movement * speed;
    }
    public void MoveLeft()
    {
        Debug.Log("Left");
        movement2 = new Vector2(-5f, 0f);
        //rb.velocity = movement2 * speed;
    }
    public void MoveRight()
    {
        movement2 = new Vector2(5f, 0f);
        //rb.velocity = movement * speed;
    }
    public void MoveRightStop()
    {
        movement2 = new Vector2(0f, 0f);
    }
}