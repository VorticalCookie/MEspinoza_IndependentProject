using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;

    private float xPosRange = 28; 
    private float zPosRange = 5;
    DetectCollisions detectCollisions;

    private int enemyCount;
    private int waveNumber = 1;
    public TextMeshProUGUI waveText;
    // Start is called before the first frame update
    void Start()
    {

        detectCollisions = GameObject.Find("Enemy").GetComponent<DetectCollisions>();
        SpawnWave(waveNumber);


       
        

    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyFollow>().Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnWave(waveNumber);
            waveText.text = "Wave: " + waveNumber;
        }

    }

  

    void SpawnWave(int enemyNum)
    {
        if (detectCollisions.gameOver == false)
        {
            Instantiate(powerUpPrefab, SpawnRandomPower(), powerUpPrefab.transform.rotation);

            for (int i = 0; i < enemyNum; i++)
            {
                Instantiate(enemyPrefab, SpawnRandomEnemy(), enemyPrefab.transform.rotation);
            }
        }
    }

    Vector3 SpawnRandomEnemy()
    {
        float randXpos = Random.Range(-xPosRange, xPosRange);
        Vector3 randPos = new Vector3(randXpos, 0, 37);


        return randPos;
    }
    Vector3 SpawnRandomPower()
    {
        float xPos = Random.Range(-xPosRange, xPosRange);
        float zPos = Random.Range(-zPosRange, zPosRange);
        Vector3 spawnPos = new Vector3(xPos, powerUpPrefab.transform.position.y, zPos);
        
        return spawnPos;
    }
}