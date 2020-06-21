using System.Collections;
using UnityEngine.Audio;
using UnityEngine;

public class Setvol : MonoBehaviour
{
    public AudioMixer mixer;
    public void Setlevel(float sliderValue)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue)*20);
    }
}
