using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public Animator animator;
    //public Animator animator3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key1")
        {
            animator.Play("DoorOpn");
        }

        //if (other.tag == "Key3")
        //{
        //    animator3.Play("DoorOpn2");
        //}
    }
}
