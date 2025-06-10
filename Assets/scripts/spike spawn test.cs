using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikespawntest : MonoBehaviour
{
   
    public RockGolemGroundSlam groundSlam;
    public float beatsPerMinute = 0;
    private float timer;

    private void Start()
    {
        beatsPerMinute = Random.Range(10, 20); 
    }

    void Update()
    {
        if (timer > 60 / beatsPerMinute * 4)
        {
            SpawnBeat();
            timer -= 60 / beatsPerMinute * 4;
            beatsPerMinute += Random.Range(-2, 4);
            if (beatsPerMinute < 10)
            {
                beatsPerMinute = Random.Range(15, 30);
            }
        }

        timer += Time.deltaTime;


    }

    void SpawnBeat()
    {
        groundSlam.TriggerGroundSlam();
    }
}

