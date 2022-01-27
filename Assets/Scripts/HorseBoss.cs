using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseBoss : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;
    public GameObject flipPoint;
    public SpriteRenderer horse;
    public Transform[] moveSpots;
    private int currentSpot;
    
    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        horse = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {               
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[currentSpot].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, moveSpots[currentSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                currentSpot += 1;
                waitTime = startWaitTime;
                if (transform.position.x > flipPoint.transform.position.x)
                {
                    horse.flipX = true;
                }
                else
                {
                    horse.flipX = false;
                }
            }
            else
            {
                waitTime -= Time.deltaTime;
            }

        }
        
        if(currentSpot == moveSpots.Length)
        {
            currentSpot = 0;
        }
    }
}
