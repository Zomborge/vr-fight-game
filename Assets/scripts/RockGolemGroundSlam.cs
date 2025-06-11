using UnityEngine;
using System.Collections;

public class RockGolemGroundSlam : MonoBehaviour
{
    public AudioClip[] musicTracks; 
    private AudioSource audioSource;
    public Animator animator;
    [Header("Spike Settings")]
    [Tooltip("Spike projectile prefab with the SpikeProjectile script attached.")]
    public GameObject spikePrefab;

    [Tooltip("The position from which the spikes are spawned.")]
    public Transform spikeSpawnPoint;

    [Tooltip("Number of spikes to spawn in a line.")]
    public int numberOfSpikes = 5;

    [Tooltip("Spacing between each spawned spike.")]
    public float spikeSpacing = 2.0f;

    [Tooltip("Delay after slam before spikes are launched.")]
    public float delayBeforeSpikeLaunch = 0.5f;

    [Header("Player Reference")]
    [Tooltip("Reference to the player Transform. If not assigned, it will be found by tag 'Player'.")]
    public Transform player;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    // This method can be called by an animation event or other game logic to trigger the slam.
    public void TriggerGroundSlam()
    {
        if (animator != null)
        {
            animator.SetTrigger("GroundSlam");
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Animator not found! Ensure the Rock Golem has an Animator component.");
        }
        StartCoroutine(GroundSlamRoutine());
    }

    private IEnumerator GroundSlamRoutine()
    {
        Debug.Log("Ground slam initiated.");

        // Optionally play your ground slam animation or effect here.

        // Wait for the specified delay before launching spikes.
        yield return new WaitForSeconds(delayBeforeSpikeLaunch);

        // Auto-find the player by tag if not already assigned.
        if (player == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null)
                player = playerObj.transform;
            else
            {
                Debug.LogWarning("Player not found! Make sure the player has the 'Player' tag.");
                yield break;
            }
        }

        // Calculate the direction from the spawn point to the player.
        Vector3 directionToPlayer = (player.position - spikeSpawnPoint.position).normalized;

        // For multiple spikes in a line, we determine a perpendicular vector.
        Vector3 perpendicular = Vector3.Cross(directionToPlayer, Vector3.up).normalized;

        // Determine starting offset so that spikes are centered around the spawn point.
        int halfCount = numberOfSpikes / 2;
        for (int i = -halfCount; i <= halfCount; i++)
        {
            Vector3 offset = perpendicular * i * spikeSpacing;
            Vector3 spawnPosition = spikeSpawnPoint.position + offset;

            // Instantiate the spike with a rotation facing the target direction.
            GameObject spike = Instantiate(spikePrefab, spawnPosition, Quaternion.LookRotation(directionToPlayer));

            // If the spike prefab has the SpikeProjectile script, assign its movement direction.
            SpikeProjectile spikeScript = spike.GetComponent<SpikeProjectile>();
            if (spikeScript != null)
            {
                spikeScript.SetDirection(directionToPlayer);
            }
        }
    }
}
