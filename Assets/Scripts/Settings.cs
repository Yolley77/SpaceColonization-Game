using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour {
    public AudioMixer sounds;
    public void soundsVolume(float sliderValue)
    {
        sounds.SetFloat("masterVolume", sliderValue);
    }

    public AudioMixer music;
    public void musicVolume(float sliderValue)
    {
        music.SetFloat("musicVolume", sliderValue);
    }
}
