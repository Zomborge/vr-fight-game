using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randommusicplayer : MonoBehaviour
{

    public AudioClip[] musicTracks; // Assign songs in the Inspector
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayRandomTrack();
    }

    void PlayRandomTrack()
    {
        if (musicTracks.Length == 0)
        {
            Debug.LogWarning("No music tracks assigned!");
            return;
        }

        // Pick a random track
        AudioClip randomTrack = musicTracks[Random.Range(0, musicTracks.Length)];
        audioSource.clip = randomTrack;
        audioSource.Play();

        // Schedule the next track when the current one finishes
        Invoke(nameof(PlayRandomTrack), randomTrack.length);
    }
}
