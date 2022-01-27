using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    public GameObject[] spawnPrefabs;
    public float radius = 1f;
    private int index = -1;
    public float spawnRate = 0.1f;

    void Start()
    {
        StartCoroutine(Wait());
    }
    // Update is called once per frame
    void Update()
    {       
        if (Input.touchCount > 0 )
        {
            Touch touch = Input.GetTouch(0);          
        }
    }

    void SpawnObjectAtRandom()
    {
        Vector3 randomPos = Random.insideUnitCircle * radius;

        index = index + 1;
        if (index == spawnPrefabs.Length)
        {
            index = 0;
        }
        for (int i = 0; i < spawnPrefabs.Length; i++)
        {
            
            if (i == index)
            {
                Instantiate(spawnPrefabs[i], randomPos, Quaternion.identity);
                
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, radius);
    }

    IEnumerator Wait()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            SpawnObjectAtRandom();
        }             
    }

    /////To spawn at finger location///////

    //Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

    //if(touch.phase == TouchPhase.Began)
    //{
    //    index = index + 1;
    //    if (index == spawnPrefabs.Length)
    //    {
    //        index = 0;
    //    }
    //    for (int i = 0; i < spawnPrefabs.Length; i++)
    //    {
    //        if (i == index)
    //        {
    //            Instantiate(spawnPrefabs[i], touchPos, Quaternion.identity);
    //        }
    //    }
    //}


}
