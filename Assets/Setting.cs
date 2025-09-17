using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public AudioSource music;
    public AudioSource sounds;
    public AudioSource footsteep;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            music.volume -= 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            music.volume += 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            sounds.volume -= 0.1f;
            footsteep.volume -= 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            sounds.volume += 0.1f;
            footsteep.volume += 0.1f;
        }
        if(sounds.volume >= 1)
        {
            sounds.volume = 1;
            footsteep.volume =1f;
        }
        if (sounds.volume <= 0)
        {
            sounds.volume = 0;
            footsteep.volume = 0;
        }



        if (music.volume >= 1)
        {
            music.volume = 1;
        }
        if (music.volume <= 0)
        {
            music.volume = 0;
        }
    }
}
