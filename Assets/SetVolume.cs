using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public void SetMusLevel(float sliderValue)
    {
        mixer.SetFloat("MusVol", Mathf.Log10(sliderValue) * 20);
    }

    public void SetSFXLevel(float sliderValue)
    {
        mixer.SetFloat("SFX", Mathf.Log10(sliderValue) * 20);
    }
}
