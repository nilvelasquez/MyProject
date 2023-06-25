using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    private BoxCollider2D box;
    private Vector3 movement;
   protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);        
    }
    void FixedUpdate()
    {
        rb.AddForce(movement * speed);
    }
    public void MoveUp()
    {
        rb.AddForce(new Vector3(0f, speed, 0f));
    }

    public void MoveDown()
    {
        rb.AddForce(new Vector3(0f,-speed, 0f));
    }

    public void MoveLeft()
    {
        rb.AddForce(new Vector3(-speed, 0f, 0f));
    }

    public void MoveRight()
    {
        rb.AddForce(new Vector3(speed, 0f, 0f));
    }
    /*
    [SerializeField] private float speed;
    public Rigidbody2D body;
    private BoxCollider2D boxCollider;
    private float horizontalInput;
    private void Awake()
    {

        //Grab references for rigidbody and animator from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Start()
    {
        pauseMenuScreen.SetActive(false);
    }

    private void Update()
    {

        Debug.Log(numberCoins);

        horizontalInput = SimpleInput.GetAxis("Horizontal");
        //horizontalInput = Input.GetAxis("Horizontal"); //TO USE AWSD

        //Flip player when moving left or right
        if (horizontalInput > 0.01f) { transform.localScale = Vector3.one; }
        else if (horizontalInput < -0.01f) { transform.localScale = new Vector3(-1, 1, 1); }

        //Set animator parameters
        anim.SetBool("walk", horizontalInput != 0);
        anim.SetBool("grounded", isGrounded());

        //Wall jump logic
        if (wallJumpCoolDown > 0.2f)
        {
            body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

            if (onWall() && !isGrounded())
            {
                body.gravityScale = 0;
                body.velocity = Vector2.zero;
            }
            else
                body.gravityScale = 7;

            if (Input.GetKey(KeyCode.Space))
                Jump();
        }
        else
            wallJumpCoolDown += Time.deltaTime;
    }

    public void Jump()
    {

        anim.SetTrigger("jump");

        if (isGrounded())
        {
            body.velocity = new Vector2(body.velocity.x, jumpPower);
            AudioManager.instance.Play("Jump");
        }
        else if (onWall() && !isGrounded())
        {
            AudioManager.instance.Play("Jump");

            if (horizontalInput == 0)
            {
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 10, 0);
                transform.localScale = new Vector3(-Mathf.Sign(transform.localScale.x), transform.localScale.y, transform.localScale.z);//?? min 16:47
            }
            else
            {
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 3, 6);
            }

            wallJumpCoolDown = 0;
        }

    }

    //to wall jumping
    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null; //si esta en el cielo
    }

    private bool onWall()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, new Vector2(transform.localScale.x, 0), 0.1f, wallLayer);
        return raycastHit.collider != null; //si esta en el cielo
    }
    public void Pause() //Pause the entire movement of the player and the game if it's equal to 0. Default is equal to 1.
    {
        Time.timeScale = 0;
        pauseMenuScreen.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseMenuScreen.SetActive(false);
    }

    public void Quit()
    {
        //ENVIAR COSAS ¿?
        Application.Quit();
        Debug.Log("Quit");
    }*/
}