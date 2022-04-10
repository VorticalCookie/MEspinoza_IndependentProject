using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    DetectCollisions detectCollisions;

    public NavMeshAgent enemy;
    public Transform Player;
    
    // Start is called before the first frame update
    void Awake()
    {

        detectCollisions = GameObject.Find("Enemy").GetComponent<DetectCollisions>();

    }

    // Update is called once per frame
    void Update()
    {
        if (detectCollisions.gameOver == false)
        {

            enemy.SetDestination(Player.position);

        }
    }
}
