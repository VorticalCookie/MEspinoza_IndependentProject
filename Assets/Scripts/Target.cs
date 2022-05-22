using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    private GameManager gameManager;

    public int pointValue;

    public ParticleSystem expParticle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
      
        if (gameObject.CompareTag("Enemy"))
        {
            
            Instantiate(expParticle, transform.position, expParticle.transform.rotation);
        }
    }
}
