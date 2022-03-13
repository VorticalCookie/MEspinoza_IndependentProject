using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float xPosRange = 13;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", 3.0f, 1.5f);
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
        Instantiate(enemyPrefabs[EnemyPrefabIndex], randPos, enemyPrefabs[EnemyPrefabIndex].transform.rotation);
    }
}
