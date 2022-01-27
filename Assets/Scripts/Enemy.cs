using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    private int randomN;
    public GameObject drop;

    void Start()
    {
        randomN = Random.Range(0, 11); 
    }

    // Update is called once per frame
    void Update()
    {
        
        if(health <= 0)
        {
            Destroy(gameObject);
            if(randomN == 1)
            {
                Instantiate(drop, this.transform.position, Quaternion.identity);
            }

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            health -= 1;
            //Debug.Log("Touch!" + collision);
        }
        
    }

}
