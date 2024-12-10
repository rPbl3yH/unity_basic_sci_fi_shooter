using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTriggerComponent : MonoBehaviour
{
    public int Damage = 1;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<HealthComponent>().TakeDamage(Damage);
        }
    }
}