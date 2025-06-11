using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingrock : MonoBehaviour
{

    public int hitCount = 0;
    public int requiredHits = 3; // Set this to the number of hits required
    public GameObject monsterSpawner;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("sword"))
        {
            hitCount++;
            if (hitCount >= requiredHits)
            {
                FallDown();
                DisableSpawner();
            }
        }
    }

    void FallDown()
    {
        // Add logic to make the item fall down, e.g., disable constraints or apply force
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.AddForce(Vector3.down * 10f, ForceMode.Impulse);
        }
    }

    void DisableSpawner()
    {
        if (monsterSpawner != null)
        {
            monsterSpawner.SetActive(false);
        }
    }

}
