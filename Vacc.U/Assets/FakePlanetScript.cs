using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakePlanetScript : MonoBehaviour
{
    public GameObject fakePlanet;
    public GameObject fakeSavep;
    void Start()
    {
        //fakePlanet.GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(fakePlanet);
        Destroy(fakeSavep);
        Destroy(gameObject);
       
    }


     
}
