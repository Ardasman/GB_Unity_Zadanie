using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public float fireRange;

    public GameObject bullEnemy;
    public GameObject bullSpawnEnemy;
    public GameObject players;

    public Transform player;
    
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

    void FixedUpdate()
    {
        if (_isPlayerInRange)
        {
            enemyFire();
        }
    }

    public void enemyFire()
    {
        Vector3 direction = player.position - transform.position + Vector3.up;
        Ray ray = new Ray(transform.position, direction);
        RaycastHit raycastHit;
        Instantiate(bullEnemy, bullSpawnEnemy.transform.position, bullSpawnEnemy.transform.rotation);
        if (Physics.Raycast(ray, out raycastHit, fireRange))
        {
            if (raycastHit.collider.transform == player)
            {
                PlayerHealthController playerHealthController = players.GetComponent<PlayerHealthController>();

                playerHealthController.TakeDamage(damageAmount);
            }
        }
    }
}
