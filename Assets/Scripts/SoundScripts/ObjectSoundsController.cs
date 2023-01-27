using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSoundsController : MonoBehaviour
{
    public AudioClip[] AudioClips;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void DoorOpenSoundPlay()
    {
        audioSource.PlayOneShot(AudioClips[0]);
    }

    public void DoorCloseSoundPlay()
    {
        audioSource.PlayOneShot(AudioClips[1]);
    }
}
