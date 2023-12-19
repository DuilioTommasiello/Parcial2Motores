using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [Header("Audio")]
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioMixer _mixer;

    [Header("UI")]
    [SerializeField] private Slider _masterSlider;
    [SerializeField] private Slider _musicSlider;
    [SerializeField] private Slider _sfxSlider;

    private void Start()
    {
        _masterSlider.value = 1f;
        _musicSlider.value = 1f;
        _sfxSlider.value = 1f;
    }

    public void SetMasterVolume(float value)
    {
        _mixer.SetFloat("MasterVolume", Mathf.Log10(value) * 20);
    }

    public void SetMusicVolume(float value)
    {
        _mixer.SetFloat("MusicVolume", Mathf.Log10(value) * 20);
    }

    public void SetSFXVolume(float value)
    {
        _mixer.SetFloat("SFXVolume", Mathf.Log10(value) * 20);
    }

    public void PlayAudio(AudioClip clip)
    {
        if (_source.clip == clip) return;

        _source.Stop();
        _source.clip = clip;
        _source.Play();
    }
}
