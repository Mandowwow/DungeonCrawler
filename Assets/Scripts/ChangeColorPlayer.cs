using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorPlayer : MonoBehaviour
{
    public SpriteRenderer player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            player.color = Color.red;
            StartCoroutine(Change());
        }

    }

    IEnumerator Change()
    {
        yield return new WaitForSeconds(0.1f);
        player.color = Color.white;
    }
}
