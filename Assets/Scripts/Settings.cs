using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour {

    public AudioMixer sounds;
    public Slider s_slid;
    public void soundsVolume(float sliderValue)
    {
        sounds.SetFloat("masterVolume", sliderValue);
    }

    public void SoundsPressed()
    {
        sounds.SetFloat("masterVolume", -80);
        s_slid.value = -80;
    }


    public AudioMixer music;
    public Slider m_slid;
    public void musicVolume(float sliderValue)
    {
        music.SetFloat("musicVolume", sliderValue);
    }

    public void MusicPressed()
    {
        music.SetFloat("musicVolume", -80);
        m_slid.value = -80;
    }


    public void Start()
    {
        if (PlayerPrefs.HasKey("music"))
        {
            music.SetFloat("musicVolume", PlayerPrefs.GetFloat("music"));
            m_slid.value = PlayerPrefs.GetFloat("music");
            Debug.Log("Music settings loaded!");
        }
        if (PlayerPrefs.HasKey("sounds"))
        {
            sounds.SetFloat("masterVolume", PlayerPrefs.GetFloat("sounds"));
            s_slid.value = PlayerPrefs.GetFloat("sounds");
            Debug.Log("Sounds settings loaded!");
        }
    }

    public void OnBackPressed()
    {
        PlayerPrefs.SetFloat("music", m_slid.value);
        Debug.Log("Music settings saved!");

        PlayerPrefs.SetFloat("sounds", s_slid.value);
        Debug.Log("Sounds settings saved!");
    }
}
