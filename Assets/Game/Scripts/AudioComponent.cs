using UnityEngine;

public class AudioComponent : MonoBehaviour
{
    public AudioSource AudioSource;

    public void PlaySound(AudioClip audioClip)
    {
        AudioSource.PlayOneShot(audioClip);
    }
}