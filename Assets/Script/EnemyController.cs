using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float damageAmount;

    public void OnCollisionWithPlayer(GameObject JohnLemon)
    {
        PlayerHealthController playerHealthController = JohnLemon.GetComponent<PlayerHealthController>();

        playerHealthController.TakeDamage(damageAmount);
    }

    internal void OnCollisionWithPlayer()
    {
        throw new NotImplementedException();
    }
}
