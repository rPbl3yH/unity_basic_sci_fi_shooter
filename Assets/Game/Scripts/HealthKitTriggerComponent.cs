using UnityEngine;

public class HealthKitTriggerComponent : MonoBehaviour
{
    public int Health = 1;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<HealthComponent>().AddHealth(Health);
            Destroy(gameObject);
        }
    }
}