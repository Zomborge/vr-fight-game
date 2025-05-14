using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class explosion : MonoBehaviour
{
    public UnityEvent slashed;
    public GameObject insides;
    public GameObject outside;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hello");
        slashed.Invoke();

    }

}
