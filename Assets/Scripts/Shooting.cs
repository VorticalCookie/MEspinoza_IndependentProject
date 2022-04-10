using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    DetectCollisions detectCollisions;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        detectCollisions = GameObject.Find("Enemy").GetComponent<DetectCollisions>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && detectCollisions.gameOver == false)
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
