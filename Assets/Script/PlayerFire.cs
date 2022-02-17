using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFire : MonoBehaviour
{
    // Mine
    public GameObject mineSpawn;
    public GameObject mine;
    public int mineCount;

    public Text textCountMine;

    // Shoot
    public float fireRange;
    public GameObject shooter;
    public GameObject bull;
    public GameObject bullSpawn;
    

    // Dynamite
    public float throwForce = 5f;
    public GameObject dynamitePrefab;
    public GameObject dynamiteSpawn;
    public int dynamiteCount;

    public Text textCountDynamite;

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

        if (Input.GetKeyDown("f"))
        {
            ThrowDynamite();
        }

        textCountDynamite.text = dynamiteCount.ToString();

    }

    public void playerFire()
    {
        RaycastHit raycastHit;
        Physics.Raycast(shooter.transform.position, shooter.transform.forward, out raycastHit, fireRange);
        Instantiate(bull, bullSpawn.transform.position, bullSpawn.transform.rotation);
    }

    public void playerMine()
    {
        if (mineCount > 0)
        {
            mineCount--;
            Instantiate(mine, mineSpawn.transform.position, mineSpawn.transform.rotation);
        }
    }

    public int DynamiteCountAdd(int addDynamite)
    {
        dynamiteCount += addDynamite;
        return dynamiteCount;
    }

    void ThrowDynamite()
    {
        if (dynamiteCount > 0)
        {
            dynamiteCount--;
            GameObject dynamite = Instantiate(dynamitePrefab, dynamiteSpawn.transform.position, transform.rotation);
        Rigidbody rb = dynamite.GetComponent<Rigidbody>();
        rb.AddForce((transform.forward + transform.up) * throwForce, ForceMode.VelocityChange);

        }
    }
}
