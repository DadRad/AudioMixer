using UnityEngine;
using UnityEngine.Audio;

public class SoundsSwitcher : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    private bool _isSoundsEnabled = true;

    public void SwitchSoundsState()
    {
        if (_isSoundsEnabled)
        {
            _audioMixer.SetFloat("MasterVolume", -80f);
            _isSoundsEnabled = false;
        }
        else
        {
            _audioMixer.SetFloat("MasterVolume", 0f);
            _isSoundsEnabled = true;
        }
    }
}
