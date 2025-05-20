using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleater : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(other.gameObject);
    }
}
