using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    DetectCollisions detectCollisions;

    public GameObject projectilePrefab;
    public ParticleSystem expParticle;
    // Start is called before the first frame update
    void Start()
    {
        detectCollisions = GameObject.Find("Enemy").GetComponent<DetectCollisions>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if(gameObject.CompareTag("Enemy"))
        {

            Instantiate(expParticle, transform.position, expParticle.transform.rotation);
            Destroy(gameObject);
        }
    }
}
