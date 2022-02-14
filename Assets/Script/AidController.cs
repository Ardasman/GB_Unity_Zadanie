using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AidController : MonoBehaviour
{
    [SerializeField] private float _heal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.GetComponent<PlayerHealthController>();
            player.AidHeal(_heal);
            Destroy(gameObject);
        }
    }
}
