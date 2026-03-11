using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundsVolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    public void ChangeMasterVolume(float volume)
    {
        _audioMixerGroup.audioMixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 20);
    }

    public void ChangeEffectsVolume(float volume)
    {
        _audioMixerGroup.audioMixer.SetFloat("EffectsVolume", Mathf.Log10(volume) * 20);
    }

    public void ChangeMusicVolume(float volume)
    {
        _audioMixerGroup.audioMixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
    }
}
