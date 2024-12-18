using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    public Animator Animator;
    public ShootComponent ShootComponent;

    public AudioSource AudioSource;
    public AudioClip StepAudioClip;

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

    public void OnStepEvent()
    {
        AudioSource.PlayOneShot(StepAudioClip);
    }
}