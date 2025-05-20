using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class disapear : MonoBehaviour
{
    public Rigidbody debris;
    private float dissapearingSpeed = 2f;
    private float size = 34.33459f;
    public float timeToStart = 5f;


    private void Update()
    {
        if (timeToStart <= 0)
        {
            // Update Size until 0, then destroy
            size -= Time.deltaTime * dissapearingSpeed;

            debris.transform.localScale = Vector3.one * size;
        }
        else {
            timeToStart -= Time.deltaTime;
        }




        if (size <= 0.05f) { 
            Destroy(gameObject);
        }
    }
}
