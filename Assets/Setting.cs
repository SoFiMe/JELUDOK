using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using System;

public class Setting : MonoBehaviour
{
    public AudioSource music;
    public AudioSource sounds;
    public AudioSource footsteep;

    public TextMeshPro textSound;
    public TextMeshPro textMusic;

    public static float saveMus = 0.3f;
    public static float saveSound = 0.1f;

    void Start()
    {
        Load();
    }

    // Update is called once per frame
    void Update()
    {
        SetInfo();
        Corrected();
    }
    public void Save()
    {
        saveMus = music.volume;
        saveSound = sounds.volume;
    }
    public void Load()
    {
        if(saveMus != music.volume)
        {
            music.volume = saveMus;
        }
        if(saveSound != music.volume)
        {
            sounds.volume = saveSound;
        }
    }
    public void SetInfo()
    {
        int intValue = (int)(sounds.volume * 10f);
        string sound = string.Concat(Enumerable.Repeat("[]", intValue));
        intValue = (int)(music.volume * 10f);
        string mus = string.Concat(Enumerable.Repeat("[]", intValue));
        textMusic.text = "Музыка " + "\n" + mus;
        textSound.text = "Звуки " + "\n" + sound;
    }
    public void plusSound()
    {
        sounds.volume += 0.1f;
        footsteep.volume += 0.1f;
        Save();
    }
    public void minusSound()
    {
        sounds.volume -= 0.1f;
        footsteep.volume -= 0.1f;
        Save();
    }
    public void plusMusic()
    {
        music.volume += 0.1f;
        Save();
    }
    public void minusMusic()
    {
        music.volume -= 0.1f;
        Save();
    }
    public void Corrected()
    {
        if (sounds.volume >= 1)
        {
            sounds.volume = 1;
            footsteep.volume = 1f;
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
