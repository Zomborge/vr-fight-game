using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtsound : MonoBehaviour
{

    public AudioClip[] hitSounds; // Assign 5 sound clips in Unity Inspector
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayHitSound()
    {
        if (hitSounds.Length > 0)
        {
            int randomIndex = Random.Range(0, hitSounds.Length); // Pick a random sound
            audioSource.PlayOneShot(hitSounds[randomIndex]);
        }
        else
        {
            Debug.LogWarning("No hit sounds assigned!");
        }
    }

}
