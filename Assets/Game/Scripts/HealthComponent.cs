using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public int MaxHealth = 10;
    public int Health = 10;

    public bool HasDamageSound;
    public AudioClip DamageSound;
    public AudioSource AudioSource;

    public bool HasHealSound;
    public AudioClip HealSound;

    public void TakeDamage(int damage)
    {
        Health = Health - damage;
        Debug.Log("Take damage! Health = " + Health);

        if (HasDamageSound)
        {
            AudioSource.PlayOneShot(DamageSound);
        }

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void AddHealth(int health)
    {
        Health = Health + health;

        Health = Mathf.Min(Health, MaxHealth);
        
        if (HasHealSound)
        {
            AudioSource.PlayOneShot(HealSound);
        }
        
        Debug.Log("Add health = " + health);
    }
}