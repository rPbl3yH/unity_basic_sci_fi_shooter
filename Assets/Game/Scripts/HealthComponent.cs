using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public int MaxHealth = 10;
    public int Health = 10;

    public void TakeDamage(int damage)
    {
        Health = Health - damage;
        Debug.Log("Take damage! Health = " + Health);

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void AddHealth(int health)
    {
        Health = Health + health;

        Health = Mathf.Min(Health, MaxHealth);
        
        Debug.Log("Add health = " + health);
    }
}