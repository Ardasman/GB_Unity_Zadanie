using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamiteThrow : MonoBehaviour
{
    public float throwForce = 5f;
    public GameObject dynamitePrefab;
    public GameObject dynamiteSpawn;

    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            ThrowDynamite();
        }
    }

    void ThrowDynamite()
    {
        GameObject dynamite = Instantiate(dynamitePrefab, dynamiteSpawn.transform.position, transform.rotation);
        Rigidbody rb = dynamite.GetComponent<Rigidbody>();
        rb.AddForce((transform.forward + transform.up) * throwForce, ForceMode.VelocityChange);
    }
}
