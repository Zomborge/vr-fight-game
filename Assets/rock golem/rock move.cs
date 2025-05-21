using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockmove : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    float speed = 2.0f;
    private void Update()
    {
        transform.LookAt(player);
        Vector3 newPosition = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        transform.position = newPosition;
        transform.Rotate(0f, 90.0f, 0.0f);
    }
}
