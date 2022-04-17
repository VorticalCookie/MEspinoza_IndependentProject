using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public bool gameOver = false;
    public GameObject GameOver;

    public ParticleSystem expSystem;

    void Start()

    {
        GameOver.SetActive(false);

    }
    private void OnTriggerEnter(Collider Other)
    {
        
        if (Other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Killed!");
            Destroy(Other.gameObject);
            Destroy(gameObject);
            expSystem.Play();
        }


        if (Other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
            GameOver.SetActive(true);
        }
    }
}
