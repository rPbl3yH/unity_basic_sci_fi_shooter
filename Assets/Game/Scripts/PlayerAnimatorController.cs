using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    public Animator Animator;
    public ShootComponent ShootComponent;

    public void ActivateRunAnimation()
    {
        Animator.SetBool("IsMoving", true);
    }
    
    public void DeactivateRunAnimation()
    {
        Animator.SetBool("IsMoving", false);
    }

    public void ActivateShootAnimation()
    {
        Animator.SetTrigger("Shoot");
    }

    public void OnShootEvent()
    {
        ShootComponent.Shoot();
    }
}