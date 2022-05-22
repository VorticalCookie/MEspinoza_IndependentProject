using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{


    public bool gameActive = false;
    private int score = 0;
    public List<GameObject> prefabs;
    public TextMeshProUGUI waveText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
   
    public GameObject titleScreen;

    // Start is called before the first frame update
    void Start()
    {
       gameActive = true;

      
    }
  
   
    // Update is called once per frame
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
      
        gameActive = false;
    }

    public void RestartGame()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
