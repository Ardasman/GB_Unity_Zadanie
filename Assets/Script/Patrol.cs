using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform player;
    public GameObject players;
    bool _isPlayerInRange;
    [SerializeField] private float damageAmount;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            _isPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {
            _isPlayerInRange = false;
        }
    }

    void Update()
    {
        if (_isPlayerInRange)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position, direction);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.collider.transform == player)
                {
                    PlayerHealthController playerHealthController = players.GetComponent<PlayerHealthController>();

                    playerHealthController.TakeDamage(damageAmount);
                }
            }
        }

        
    }
}
