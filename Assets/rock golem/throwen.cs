using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class throwen : XRGrabInteractable
{
    

    private Vector3 lastPosition;
    private Vector3 velocity;


    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        lastPosition = transform.position;
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = velocity;
    }

    void FixedUpdate()
    {
        if (isSelected)
        {
            velocity = (transform.position - lastPosition) / Time.fixedDeltaTime;
            lastPosition = transform.position;
        }
    }

}
