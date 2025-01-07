using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float health = 3f; 
    [SerializeField] float maxHealth = 3f;
    [SerializeField] AIHealthBar healthbar; 

    void Awake()
    {
        healthbar = GetComponentInChildren<AIHealthBar>();
        healthbar.UpdateHealthBar(health, maxHealth);
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        healthbar.UpdateHealthBar(health, maxHealth);
        if (health <= 0)
        {

        }
    }
    void Update()
    {
        
    }
}
