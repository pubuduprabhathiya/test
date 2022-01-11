using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class audioManage : MonoBehaviour
{
    public sound[] sounds;
    public static audioManage instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach (sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    void Start()
    {
       
    }
    public void play(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) return;
        s.source.Play();

    }
    public void stop(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) return;
        s.source.Stop();

    }
   
}
