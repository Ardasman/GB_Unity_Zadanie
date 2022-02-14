using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFirstAid : MonoBehaviour
{

    public GameObject firstAidPrefabs;
    public Transform[] AidPrefabs;
    public float AidInGameMax;
    float AidInGameCurrent = 0f;

    void Update()
    {  
           if(AidInGameCurrent < AidInGameMax)
        { 

            int firstAidIndex = Random.Range(0, AidPrefabs.Length);
            Transform pos = AidPrefabs[firstAidIndex];

            Instantiate(firstAidPrefabs, pos.transform.position, firstAidPrefabs.transform.rotation);

            AidInGameCurrent++;
        }


    }
}
