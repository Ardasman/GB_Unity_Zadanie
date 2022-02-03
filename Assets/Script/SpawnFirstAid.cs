using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFirstAid : MonoBehaviour
{
    [SerializeField]  private float _spawnRangeX = 40f;
    [SerializeField]  private float _spawnPosZ = 40f;

    public GameObject[] _firstAidPrefabs;



    void Start()
    {
        
    }

    void Update()
    {
        
            Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, Random.Range(-_spawnPosZ, _spawnPosZ));
            int firstAidIndex = Random.Range(0, _firstAidPrefabs.Length);
            Instantiate(_firstAidPrefabs[firstAidIndex], spawnPos, _firstAidPrefabs[firstAidIndex].transform.rotation);
            Destroy(gameObject, 0.38f);


    }
}
