using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    [SerializeField] private AudioSource _musicSource, _effectsSource;
    [SerializeField] private AudioMixer _mixer;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        _effectsSource.PlayOneShot(clip);
    }

    public void StopSFX()
    {
        _effectsSource.Stop();
    }

    public void PlayMusic(AudioClip clip)
    {
        _musicSource.clip = clip;
        _musicSource.Play();
    }

    public void ChangeMasterVolume(float value)
    {
        _mixer.SetFloat("MasterVolume", Mathf.Log10(value) * 20);
    }

    public void ChangeMusicVolume(float value)
    {
        _mixer.SetFloat("VolumeMusic", Mathf.Log10(value) * 20);
    }

    public void ChangeSFXVolume(float value)
    {
        _mixer.SetFloat("VolumeSFX", Mathf.Log10(value) * 20);
    }

    public float GetVolumeFromMixer(string type)
    {
        switch (type)
        {
            case "master":
                _mixer.GetFloat("MasterVolume", out float volumeMaster);
                volumeMaster = Mathf.Pow(10f, volumeMaster / 20);
                return volumeMaster;
            case "music":
                _mixer.GetFloat("VolumeMusic", out float volumeMusic);
                volumeMusic = Mathf.Pow(10f, volumeMusic / 20);
                return volumeMusic;
            case "SFX":
                _mixer.GetFloat("VolumeSFX", out float volumeSFX);
                volumeSFX = Mathf.Pow(10f, volumeSFX / 20);
                return volumeSFX;
            default:
                return 1f;//String incompativel
        }
    }
}
