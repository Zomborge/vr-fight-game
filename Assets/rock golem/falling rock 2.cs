using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingrock2 : MonoBehaviour
{
    public score score;
    public spawner spawner;
    public int hitCount = 0;
    public int requiredHits = 3; // Set this to the number of hits required
    public GameObject monsterSpawner_rock;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("sword"))
        {
            hitCount++;
            if (hitCount >= requiredHits)
            {
                FallDown();
                DisableSpawner();
                IncreaseSpawnerBPM();
                
            }
        }
        if (collision.gameObject.CompareTag("floor"))
        {
            score.boldo_down();
            Destroy(gameObject);
        }
    }
    void IncreaseSpawnerBPM()
    {

        spawner.IncreaseBPM();
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
        if (monsterSpawner_rock != null)
        {
            monsterSpawner_rock.SetActive(true);
        }
    }

}
