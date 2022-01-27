using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cthuhlu : MonoBehaviour
{
    public GameObject spawnMe;
    public float fireRate;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    void Spawn()
    {
        Instantiate(spawnMe, transform.position, transform.rotation);
    }
    IEnumerator Wait()
    {
        while (true)
        {
            yield return new WaitForSeconds(fireRate);
            Spawn();
        }
    }
}

