using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDynamite : MonoBehaviour
{
    [SerializeField] private int countAdd;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.GetComponent<PlayerFire>();
            player.DynamiteCountAdd(countAdd);
            Destroy(gameObject);
        }
    }
}
