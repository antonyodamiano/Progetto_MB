using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    
    public int health = 30;
    public int currenthealth;
    public HealthBar healthbar;
    public GameObject restartMenu;
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
        if (currenthealth == 0)
        {
            Time.timeScale = 0f;
            FindObjectOfType<Timer>().Finish();
            FindObjectOfType<AudioManager>().Play("Game_Over");
            FindObjectOfType<GameManager>().EndGame();
            restartMenu.SetActive(true);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            FindObjectOfType<AudioManager>().Play("destroy_enemy");
            Destroy(collision.gameObject);
            TakeDamage(1);

        }
    }

    
}
