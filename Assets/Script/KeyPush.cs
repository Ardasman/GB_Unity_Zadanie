using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPush : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject, 0.2f);
        Debug.Log(" нажал на кнопку");
    }
}
