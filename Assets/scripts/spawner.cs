using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour

{
    public GameObject[] cubes;
    public Transform[] spawnPoints;
    public float beatsPerMinute = 0;
    private float timer;




    void Update()
    {
        if(timer > 60 / beatsPerMinute * 4)
        {
            SpawnBeat();
            timer -= 60 / beatsPerMinute * 4;
        }

        timer += Time.deltaTime;
       

    }

    void SpawnBeat()
    {
        Instantiate(cubes[Random.Range(0, cubes.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)]);
    }
}