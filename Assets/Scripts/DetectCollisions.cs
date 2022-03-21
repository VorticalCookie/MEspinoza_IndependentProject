using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider Other)
    {
        
        if (Other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game Over!");
            Destroy(Other.gameObject);
            Destroy(gameObject);
        }
    }
}
