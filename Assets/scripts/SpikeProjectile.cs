using UnityEngine;

public class SpikeProjectile : MonoBehaviour
{
    public score addscore;
    [Tooltip("Speed at which the spike moves.")]
    public float speed = 10f;

    [Tooltip("Time (in seconds) before the spike is destroyed automatically.")]
    public float lifeTime = 5f;

    // The movement direction, set by the rock golem script.
    private Vector3 direction;

    // Method to assign the travel direction.
    public void SetDirection(Vector3 dir)
    {
        direction = dir.normalized;
    }

    private void Start()
    {
        // Destroy the spike after its lifetime elapses.
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        // Move the spike in the set direction.
        transform.position += direction * speed * Time.deltaTime;
    }

    // Optional: Handle collisions with the player.
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("spike ouch");
            Destroy(gameObject);
            addscore.ComboLoss();
        }
    }
}
