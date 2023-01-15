using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundsController : MonoBehaviour
{
    public AudioClip[] AudioClips;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayerStepSoundPlay()
    {
        audioSource.PlayOneShot(AudioClips[0]);
    }
}
