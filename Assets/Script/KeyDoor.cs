using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public Animator animatorDoor;
    public Animator animatorKey;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key1")
        {
            animatorDoor.Play("DoorOpn");
            animatorKey.Play("BootOn");
        }

        //if (other.tag == "Key3")
        //{
        //    animator3.Play("DoorOpn2");
        //}
    }
}
