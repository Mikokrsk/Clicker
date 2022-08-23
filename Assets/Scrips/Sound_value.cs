using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_value : MonoBehaviour
{
    private float sound = 0.5f;
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        sound= PlayerPrefs.GetFloat("sound");
        audio.volume = sound;
    }
}
