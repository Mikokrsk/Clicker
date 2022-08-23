using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Go_to_home : MonoBehaviour
{
    public float sound;
    private AudioSource audio;
    public GameObject button_on;
    public GameObject button_off;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
       // sound  = PlayerPrefs.GetFloat("sound");
    }
    public void Go_to_Home()
    {
       
        PlayerPrefs.SetFloat("sound", sound);
        SceneManager.LoadScene(0);
    }

    public void Sound(float val)
    {
        sound = val;
      audio.volume = sound;
        if(sound==0)
        {
            button_on.gameObject.SetActive(false);
            button_off.gameObject.SetActive(true);
        }
        else
        {
            button_on.gameObject.SetActive(true);
            button_off.gameObject.SetActive(false);
        }
    }
}
