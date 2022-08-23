using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_value_slider : MonoBehaviour
{
    private float slider_value= 0.5f;
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value= PlayerPrefs.GetFloat("sound");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
