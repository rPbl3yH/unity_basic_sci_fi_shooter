using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootComponent : MonoBehaviour
{
    public Transform ShootPoint;
    public int Damage;
    
    public void Shoot()
    {
        Vector3 shootPosition = ShootPoint.position;
        var direction = ShootPoint.forward;

        if (Physics.Raycast(shootPosition, direction, out var hitInfo))
        {
            Debug.Log("Hit! Object = " + hitInfo.collider.name);
            if (hitInfo.collider.TryGetComponent(out HealthComponent healthComponent))
            {
                healthComponent.TakeDamage(Damage);
            }
        }
    }
}
