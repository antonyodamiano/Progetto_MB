using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;


public class MoveScript : MonoBehaviour {

	float directionX;
	public float moveSpeed = 5f;
	Rigidbody2D rb;
    Animator anim;
    

    // Use this for initialization
    void Start () {
		rb = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		directionX = CrossPlatformInputManager.GetAxis ("Horizontal");
        if (directionX != 0)
        {
            anim.SetFloat("IsMoving", 1);
        }
        
       
        


    }

	void FixedUpdate()
	{
		rb.velocity = new Vector2 (directionX * moveSpeed, rb.velocity.y);
        if (rb.velocity == new Vector2(0,0))
        {
            anim.SetFloat("IsMoving", 0);
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
