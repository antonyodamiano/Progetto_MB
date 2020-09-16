using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;


public class movePlayer1 : MonoBehaviour
{
    public Joystick j;
    public float velocity;
    public float jumpForce;
    public bool isJumping;
    Animator anim;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (j.Horizontal >= 0f)
        {
            rb.velocity = new Vector2(j.Horizontal * velocity, rb.velocity.y);
            rb.transform.localScale = new Vector2(1, 1);
            

        }
        else if (j.Horizontal <= 0f )
        {

            rb.velocity = new Vector2(j.Horizontal*velocity, rb.velocity.y);
            rb.transform.localScale = new Vector2(-1, 1);

        }

        

        else if (j.Horizontal == 0)

             rb.velocity = new Vector2(0f, rb.velocity.y);

        Jump();

        anim.SetFloat("IsMoving", Mathf.Abs(j.Horizontal));
        anim.SetBool("IsJumping", isJumping);
       
        
    }
    
    void Jump()
    {
        if (!isJumping && CrossPlatformInputManager.GetButton("Jump"))
        {
            isJumping = true;
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
        }
    }
   
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("house"))
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), rb.GetComponent<Collider2D>());
        }

    }

    
}
