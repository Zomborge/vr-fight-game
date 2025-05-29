using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercolider : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    private void Update()
    {
        Vector3 newPosition = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime);
    }
}
