using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoorObject : MonoBehaviour
{
    public Animator animator2;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Key2")
        {
            animator2.Play("DoorOpn2");
        }
    }
}
