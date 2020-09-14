using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public int health = 30;
    public int currenthealth;
    public HealthBar healthbar;
    public moveEnemy virus;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = health;
        healthbar.SetMaxHealth(health);
    }

    // Update is called once per frame
    

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        healthbar.SetHealth(currenthealth);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            TakeDamage(1);

        }
    }

    private void moveEnemy(GameObject gameObject)
    {
        throw new NotImplementedException();
    }
}
