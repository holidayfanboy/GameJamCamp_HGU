using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 3f; 
    public float maxHealth = 3f;
    public AIHealthBar healthbar; 
    private Vector3 initialPosition;
    [SerializeField] AIMovement ai;
    void Awake()
    {
        initialPosition = transform.position;
        healthbar = GetComponentInChildren<AIHealthBar>();
        healthbar.UpdateHealthBar(health, maxHealth);
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        healthbar.UpdateHealthBar(health, maxHealth);
        if (health <= 0)
        {
            StartCoroutine(ai.Respawn());
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            TakeDamage(0.2f);
        }
        if (collision.gameObject.tag == "Bomb")
        {
            TakeDamage(1f);
        }
    }

    
}
