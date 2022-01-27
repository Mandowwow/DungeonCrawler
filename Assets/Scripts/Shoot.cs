using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject spawnMe;
    public GameObject spawnMeBlack;
    public static float fireRate = 0.5f;
    private float nextFire = 0;

    public void Spawn()
    {
        if(Time.time > nextFire && PlayerHealth.shield == false)
        {
            nextFire = fireRate + Time.time;
            Instantiate(spawnMe, transform.position, transform.rotation);
        }
        else if (Time.time > nextFire && PlayerHealth.shield == true)
        {
            nextFire = fireRate + Time.time;
            Instantiate(spawnMeBlack, transform.position, transform.rotation);
        }
       
    }

}