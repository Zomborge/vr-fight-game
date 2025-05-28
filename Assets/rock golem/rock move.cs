using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockmove : MonoBehaviour
{
    private GameObject player;


    [SerializeField]
    private Animator _jumpAnimation;
    float speed = 2.0f;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        transform.LookAt(player.transform);
        Vector3 newPosition = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        transform.position = newPosition;
        transform.Rotate(0f, 90.0f, 0.0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "jump it")
        {
            _jumpAnimation.SetTrigger("jumo");
        }
    }
}
