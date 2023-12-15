using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRequester : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioClip _clip;

    private void Start()
    {
        AudioManager.Instance.PlayAudio(_clip);
    }
}
