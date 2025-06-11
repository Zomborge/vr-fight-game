
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class sword : MonoBehaviour

{

    public float velocityThreshold = 1.0f; // Adjust this value as needed
    private BoxCollider swordCollider;
    private Rigidbody rb;
    private Vector3 lastPosition;

    void Start()
    {
        swordCollider = GetComponent<BoxCollider>();
        rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        rb.sleepThreshold = 0;
        lastPosition = transform.position;
    }

    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;
        Vector3 velocity = (currentPosition - lastPosition) / Time.fixedDeltaTime;
        lastPosition = currentPosition;

        if (velocity.magnitude > velocityThreshold)
        {
            swordCollider.enabled = true;
        }
        else
        {
            swordCollider.enabled = false;
        }
    }


}

