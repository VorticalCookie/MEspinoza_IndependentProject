using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float xPosRange = 13;
    //private FirstPersonController playerCtrl;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", 5.0f, 1.5f);
        //playerCtrl = GameObject.Find("Player").GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {



    }

    void SpawnRandomEnemy()

    {
        float randXpos = Random.Range(-xPosRange, xPosRange);
        int EnemyPrefabIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 randPos = new Vector3(randXpos, 0, 21);
       
       //if (playerCtrl.gameOver == false)
        //{
            Instantiate(enemyPrefabs[EnemyPrefabIndex], randPos, enemyPrefabs[EnemyPrefabIndex].transform.rotation);
       // }
    }
}
