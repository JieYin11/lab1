using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioClip pickupSound;

    private AudioSource audioSource;

    private void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayPickupSound()
    {
        audioSource.PlayOneShot(pickupSound);
    }
}
