using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] spawnPoints;
    public float beatsPerMinute = 120f; // starting BPM
    [Tooltip("Chance to increase BPM each beat (0-1)")]
    public float chanceToIncreaseBPM = 0.2f; // 20% chance per beat
    [Tooltip("Amount to increase BPM when triggered")]
    public float bpmIncrement = 5f;

    private float timer;

    void Update()
    {
        // Calculate beat interval based on current BPM.
        float beatInterval = (60f / beatsPerMinute) * 4f;
        if (timer > beatInterval)
        {
            SpawnBeat();
            timer -= beatInterval;
        }

        timer += Time.deltaTime;
    }

    void SpawnBeat()
    {
        Instantiate(cubes[Random.Range(0, cubes.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)]);


    }
    public void IncreaseBPM()
    {
        beatsPerMinute += 60;
        Debug.Log("BPM increased to: " + beatsPerMinute);
    }
}
