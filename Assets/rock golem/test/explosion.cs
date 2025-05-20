using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class explosion : MonoBehaviour
{
    public UnityEvent slashed;
    public GameObject insides;
    public GameObject outside;
    public score addscore;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "sword") { 
        Debug.Log("hello");
        slashed.Invoke();
        addscore.OnPointGain();
        }

    }

}
