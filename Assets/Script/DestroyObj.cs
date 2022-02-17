using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{

    public void DestrObj()
    {
        Destroy(gameObject, 0.5f);
    }

    public void DestrObjEffect()
    {
        Destroy(gameObject, 1.5f);
    }


}
