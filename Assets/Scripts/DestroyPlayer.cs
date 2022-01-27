using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Vector3 spawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            spawnPoint = new Vector3(spawnPoint.x, spawnPoint.y);
            Debug.Log("Touch!");
            collision.gameObject.transform.position = spawnPoint;
            
        }
        
    }
}
