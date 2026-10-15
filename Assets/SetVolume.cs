using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    float currentVolume;
    public void SetMusVolume(float volume)
    {
        mixer.SetFloat("Volume", volume);
        currentVolume = volume;
    }

    public void SetSFXLevel(float sliderValue)
    {
        mixer.SetFloat("SFX", Mathf.Log10(sliderValue) * 20);
    }
}
