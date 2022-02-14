using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFire : MonoBehaviour
{
    public float fireRange;
    public float mineCount;

    public Text textCountMine;

    public GameObject shooter;
    public GameObject bull;
    public GameObject bullSpawn;
    public GameObject mineSpawn;
    public GameObject mine;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            playerFire();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            playerMine();
        }

        textCountMine.text = mineCount.ToString();
    }

    public void playerFire()
    {
        RaycastHit raycastHit;
        Instantiate(bull, bullSpawn.transform.position, bullSpawn.transform.rotation);
        Physics.Raycast(shooter.transform.position, shooter.transform.forward, out raycastHit, fireRange);
       
    }

    public void playerMine()
    {
        if (mineCount > 0)
        {
            mineCount--;
            Instantiate(mine, mineSpawn.transform.position, mineSpawn.transform.rotation);
        }
        

    }
}
