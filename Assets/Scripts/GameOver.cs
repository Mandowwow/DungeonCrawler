using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject rip;
    public GameObject mainCamera;
    public GameObject player;
    
    void Update()
    {
        if (PlayerHealth.health <= 0)
        {
            player.SetActive(false);
            rip.SetActive(enabled);
        }
    }

    public void Restart()
    {
        PlayerHealth.shield = false;
        PlayerHealth.health = 4;
        Shoot.fireRate = 0.5f;
        Key.haveKey = false;
        SceneManager.LoadScene("Skulls");
    }
   
}
