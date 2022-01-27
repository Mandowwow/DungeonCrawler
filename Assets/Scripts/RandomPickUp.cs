using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPickUp : MonoBehaviour
{
    public GameObject[] pickUps;
    public GameObject spawnPoint;
    void Start()
    {      
        RandomNumber();        
    }
    void RandomNumber()
    {
        int randomNum = Random.Range(0, pickUps.Length);
        Instantiate(pickUps[randomNum], spawnPoint.transform.position, Quaternion.identity);
        Debug.Log(randomNum);
        
    }
}
