using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && Key.haveKey == true)
        {
            Destroy(gameObject);
            //To destroy key after using it to open gate.
            //Key.haveKey = false;
        }
    }
}
