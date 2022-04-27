using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public bool gameOver = false;
    public GameObject GameOver;

    public GameObject PowerUpIndicator;
    bool hasPowerUp = false;


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

        }


        if (Other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
            GameOver.SetActive(true);
        }
      
        if (Other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(Other.gameObject);
            StartCoroutine(PowerUpCountdown());
            PowerUpIndicator.SetActive(true);
        }

    }

    IEnumerator PowerUpCountdown()
    {
        yield return new WaitForSeconds(8);
        hasPowerUp = false;
        PowerUpIndicator.SetActive(false);
    }
}
