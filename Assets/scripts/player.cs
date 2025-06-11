using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private GameObject can;

    private void Start()
    {
        can = GameObject.FindGameObjectWithTag("MainCamera");
    }
    private void Update()
    {

        Vector3 newPosition = Vector3.MoveTowards(transform.position, can.transform.position, 1f);
        transform.position = newPosition;
    }

}
