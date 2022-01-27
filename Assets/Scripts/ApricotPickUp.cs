using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApricotPickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Shoot.fireRate -= 0.1f;
            Destroy(gameObject);
            Debug.Log(Shoot.fireRate);
        }
    }
}
