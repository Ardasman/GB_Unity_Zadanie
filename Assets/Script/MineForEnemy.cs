using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineForEnemy : MonoBehaviour
{
    [SerializeField] private float _damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var enemy = other.GetComponent<EnemyHealthController>();
            enemy.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}
