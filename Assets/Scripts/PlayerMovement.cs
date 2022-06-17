using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator anim;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    public float xSpeed = 3;
    public float yJump = 3;

    
    public static bool colorToggle = true;

    [SerializeField]
    private Color colorToTurnTo = Color.white;

    bool isGrounded;
    [SerializeField]
    Transform groundCheck = null;
    [SerializeField]
    Transform groundCheckL = null;
    [SerializeField]
    Transform groundCheckR = null;

    private CircleCollider2D circleCollider2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        circleCollider2d = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("left shift"))
        {
            colorToggle = !colorToggle;

        }
    }

    private void FixedUpdate()
    {
        //groundCheck

        
        if((Physics2D.Linecast(circleCollider2d.bounds.center, groundCheck.position, 1 << LayerMask.NameToLayer("Walls"))) ||
            (Physics2D.Linecast(circleCollider2d.bounds.center, groundCheckL.position, 1 << LayerMask.NameToLayer("Walls"))) ||
            (Physics2D.Linecast(circleCollider2d.bounds.center, groundCheckR.position, 1 << LayerMask.NameToLayer("Walls"))))
        { 
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        //moving right
        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(xSpeed, rb2d.velocity.y);


            if (isGrounded && colorToggle == true)
            {

                anim.Play("PlayerB_Run");
            }
            else if(isGrounded && colorToggle == false)
            {
                anim.Play("PlayerR_Run");
            }

            spriteRenderer.flipX = false;
        }

        //moving left
        else if(Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-xSpeed, rb2d.velocity.y);


            if (isGrounded && colorToggle == true)
            {
                anim.Play("PlayerB_Run");
            }
            else if(isGrounded && colorToggle == false)
            {
                anim.Play("PlayerR_Run");
            }

            spriteRenderer.flipX = true;
        }

        //Idle
        else
        {

            if (isGrounded && colorToggle == true)
            {
                anim.Play("PlayerB_Idle");
            }

            else if (isGrounded && colorToggle == false)
            {
                anim.Play("Player(Red)_Idle");
            }
            

            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }

        //Jump
        if (Input.GetKey("space") && isGrounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, yJump);
            if(colorToggle == true)
            {
                anim.Play("PlayerB_Jump_Imp");
            }
            else if(colorToggle == false)
            {
                anim.Play("PlayerR_Jump_Imp");
            }
            
            audioSource.Play();
        }
        if (!isGrounded)
        {
            if (colorToggle == true)
            {
                anim.Play("PlayerB_Jump_Imp");
            }
            else if (colorToggle == false)
            {
                anim.Play("PlayerR_Jump_Imp");
            }

        }


    }
    

}
