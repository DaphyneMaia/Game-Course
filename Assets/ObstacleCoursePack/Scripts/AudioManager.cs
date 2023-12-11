using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager instance;

    void Awake()
    {
        if (instance == null)/*if there is no audioManager in scene*/
        {
            instance = this;
        }
        else /*if there IS an audiomanager already*/
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject); 
        /*dont destroy/reload AudioManager between scenes*/

        /*foreach loop - run through list of 
         sounds in array and add Sound class properties to it*/
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if(s==null)/*if no sound by that name is found*/
        {
            Debug.LogWarning("Sound:" + name + "not found!");
            return;/*return to gameplay without error*/
        }
        s.source.Play();

    }
    public void StopMusic(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null)/*if no sound by that name is found*/
        {
            Debug.LogWarning("Sound:" + name + "not found!");
            return;/*return to gameplay without error*/
        }
        s.source.Stop();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
