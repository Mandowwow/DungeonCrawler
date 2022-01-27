using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public bool melee = true;
    public float speed = 5;
    private Transform player;
    float distanceFromPlayer = 0;
    public float meleeRange;
    public float shootingRange;
    public float LineOfSight;
    private float nextFire;
    public float fireRate = 1;

    public GameObject bullet;
    public GameObject bulletParent;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Melee
        distanceFromPlayer = Vector2.Distance(player.transform.position, transform.position);
        if(distanceFromPlayer < LineOfSight && distanceFromPlayer > meleeRange && melee == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }

        //Ranged
        if (distanceFromPlayer < LineOfSight && distanceFromPlayer > shootingRange && melee == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
        else if (distanceFromPlayer <= shootingRange && nextFire < Time.time && melee == false)
        {
            Instantiate(bullet, bulletParent.transform.position, Quaternion.identity);
            nextFire = fireRate + Time.time;    
        }

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, LineOfSight);
        Gizmos.DrawWireSphere(transform.position, meleeRange);
        Gizmos.DrawWireSphere(transform.position, shootingRange);
    }
}
