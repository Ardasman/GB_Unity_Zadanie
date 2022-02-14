using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemy : MonoBehaviour
{
    public float speedRotate = 0;

    void FixedUpdate()
    {
        transform.Rotate(0, speedRotate * Time.deltaTime, 0);
    }
}
