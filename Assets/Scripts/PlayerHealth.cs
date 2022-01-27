using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static int health = 3;
    public int numOfHearts;
    public float meleeRate = 1;
    public static bool shield = false;
    public GameObject shieldObj;

    public Image[] hearts;
    public Sprite fullHearts;
    public Sprite emptyHearts;

    // Update is called once per frame
    void Update()
    {
        if(health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHearts;
            } else
            {
                hearts[i].sprite = emptyHearts;
            }
            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        
        if(shield == true)
        {
            shieldObj.SetActive(enabled);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") )
        {
            health -= 1;
            //Debug.Log("Touch!" + collision);
        }

        if(collision.CompareTag("PickUp"))
        {
            shield = true;
            Debug.Log("Pickup");
        }


    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        health -= 1;
    //        Debug.Log("Touch!" + collision);
    //    }

    //}



}
