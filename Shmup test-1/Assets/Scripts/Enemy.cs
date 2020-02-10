using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    private Rigidbody2D rb;
    public int enemySpeed = -2;


    Highscore highscore;
    public int points;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        highscore = GameObject.FindObjectOfType<Highscore>();

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, enemySpeed);
    }
    public void TakeDamage (int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            
            Die();
        }
    }
    void Die()
    {
        highscore.addScore(points);
        Destroy(gameObject);
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Deleter")
        {
            Die();
        }
    }

}
