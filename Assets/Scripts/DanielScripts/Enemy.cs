using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float health = 3f; 
    [SerializeField] float maxHealth = 3f;
    [SerializeField] AIHealthBar healthbar;
    [SerializeField] GameObject gamemanager;
    [SerializeField] 
    private Vector3 initialPosition;

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
            //StartCoroutine(Respawn());
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            TakeDamage(0.2f);
        }
    }

    
}
