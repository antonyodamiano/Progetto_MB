using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Map"))
        {
            Destroy(this.gameObject);

        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }
        if (!(collision.gameObject.CompareTag("Enemy")))
        {

            Physics2D.IgnoreLayerCollision(10, 0);
            Physics2D.IgnoreLayerCollision(10, 9);
            Physics2D.IgnoreLayerCollision(10, 10);
        }
        
    }

    
}
