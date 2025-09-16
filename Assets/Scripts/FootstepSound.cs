using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] footstepSounds;
    public float volume = 0.5f;

    public void PlayFootstep()
    {
        if (footstepSounds.Length > 0)
        {
            AudioClip randomClip = footstepSounds[Random.Range(0, footstepSounds.Length)];
            audioSource.PlayOneShot(randomClip, volume);
        }
    }
}
