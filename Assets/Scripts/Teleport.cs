using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject teleportDest;
    public GameObject camera;
    public GameObject cameraDest;
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.gameObject.transform.position = teleportDest.gameObject.transform.position;
            camera.gameObject.transform.position = cameraDest.gameObject.transform.position;
            Debug.Log("Hello tag Player");
        }
    }
}
