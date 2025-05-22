using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class headrelease : MonoBehaviour
{
    public disapear headDisapear;
    public GameObject head;
    // Start is called before the first frame update
    void Start()
    {
        head.tag = "sword";
    }

    private void OnTriggerEnter(Collider other)
    {
        headDisapear.timeToStart = 0;
        headDisapear.size -= 2;
    }



}
