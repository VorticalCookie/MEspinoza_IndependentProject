using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topOfScene = 40.0f;
    private float bottomOfScene = -10.0f;

    private float rightOfScene = 30.0f;
    private float leftOfScene = -20.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topOfScene)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomOfScene)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }

        if (transform.position.x > rightOfScene)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < leftOfScene)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
