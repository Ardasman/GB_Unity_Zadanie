using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bull : MonoBehaviour
{
    public float speed;
    public float fireDamage;
    //public GameObject bullEffect;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Destroy(gameObject, 0.5f);

        //BullFire();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var enemy = other.GetComponent<EnemyHealthController>();
            enemy.TakeDamage(fireDamage);
        }
    }

    //void BullFire()
    //{
    //    GameObject bullFire = Instantiate(bullEffect, transform.position, transform.rotation);
    //    if (bullFire != null)
    //    {
    //        Destroy(bullFire, 0.5f);
    //    }
    //}
}   
