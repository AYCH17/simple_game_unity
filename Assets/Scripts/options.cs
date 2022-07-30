using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class options : MonoBehaviour
{
    public GameObject Panel;
    bool visible = false;

    public Dropdown DResolution;

    public AudioSource audioSource;
    public Slider slider;
    public Text TxtVolume;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            visible = !visible;
            Panel.SetActive(visible);
        }
    }

    public void SetResolution()
    {
        switch(DResolution.value)
        {
            case 0:
               Screen.SetResolution(640, 360, true);
               break;
           
            case 1:
               Screen.SetResolution(1920, 1080, true);
               break;
        } 
    }

    public void sliderChanger()
    {
        audioSource.volume = slider.value;
        TxtVolume.text = "Volume" + (audioSource.volume * 100).ToString("00") + "%";
    }


}
