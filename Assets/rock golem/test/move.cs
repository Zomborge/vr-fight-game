using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField]
    float speed = 2.0f;

    private void Update()
    {
        transform.position -= Time.deltaTime * transform.right * speed;
    }
}
