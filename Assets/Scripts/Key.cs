using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    //change key bool 
    public static bool haveKey = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            haveKey = true;
            Destroy(gameObject);
        }
    }
}
