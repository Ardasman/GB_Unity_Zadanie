using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public float delay = 3f;
    public float radius = 5f;
    public float force = 700f;
    public float damage = 49f;
    public GameObject explodeEffect;

    float _count;
    bool _isBoom = false;


    void Start()
    {
        _count = delay;
    }

    void Update()
    {
        _count -= Time.deltaTime;
        if (_count <= 0f && !_isBoom)
        {
            ExplodeDynamite();
            _isBoom = true;
            Destroy(gameObject);
        }

    }

    void ExplodeDynamite()
    {
        GameObject effect = Instantiate(explodeEffect, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider obj in colliders)
        {
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null)
            {
                //rb.AddExplosionForce(force, transform.position, radius);
                rb.AddRelativeForce(Vector3.forward * force, ForceMode.Force);
            }
            DestroyObj des = obj.GetComponent<DestroyObj>();
            if (des != null)
            {
                des.DestrObj();
            }

            if (obj.gameObject.CompareTag("Enemy"))
            {
                var enemy = obj.GetComponent<EnemyHealthController>();
                enemy.TakeDamage(damage);
            }

            if (obj.gameObject.CompareTag("Player"))
            {
                PlayerHealthController playerHealthController = obj.GetComponent<PlayerHealthController>();
                playerHealthController.TakeDamage(damage);
            }
        }

        DestroyObj effectObj = effect.GetComponent<DestroyObj>();
        if (effectObj != null)
        {
            effectObj.DestrObjEffect();
        }
    }
}
