using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable] //make visible to Unity system
public class Sound 
{
    public string name; //name of sound
    public AudioClip clip; //mp3/wav file

    [Range(0f, 1f)]
    public float volume;
    [Range(0.1f, 3f)]
    public float pitch; //high/low pitch

    public bool loop; //loop sound on/off

    [HideInInspector] //hides this data in Unity
    public AudioSource source;


}
