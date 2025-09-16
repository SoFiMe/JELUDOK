using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    AudioSource audioSource;

    public AudioClip[] clips;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButton()
    {
        audioSource.PlayOneShot(clips[0]);
    }
    public void PlayLever()
    {
        audioSource.PlayOneShot(clips[1]);
    }
}
