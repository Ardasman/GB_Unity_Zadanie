using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public float healthBase;
    public float healthCurrent;

    void Start()
    {
        SetHealth();
    }

    public void SetHealth()
    {
        healthCurrent = healthBase;
    }

    public void TakeDamage(float amountDamage)
    {
        healthCurrent -= amountDamage;
        if (healthCurrent <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void AidHeal(float amountHeal)
    {
        healthCurrent += amountHeal;
        if (healthCurrent > healthBase)
        {
            SetHealth();
        }
    }
}
