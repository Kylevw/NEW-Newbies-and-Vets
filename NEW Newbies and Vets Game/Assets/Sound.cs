﻿using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound{

    public string name;

    public AudioClip clip;

    [Range(0, 1)]
    public float volume;

    [Range(0.1f, 3)]
    public float pitch;
    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
