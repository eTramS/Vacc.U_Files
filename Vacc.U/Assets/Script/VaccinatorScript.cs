using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaccinatorScript : MonoBehaviour
{
    // public Rigidbody2D body;
    // public float horizontal = 1f;
    // bool isGrounded;
    // public bool Walking;
    // public SpriteRenderer sprite;
    // Start is called before the first frame update
    [SerializeField] Transform[] Pos1;
    [SerializeField] float horizontal;

    int NextnaPwesto;
    Transform NextPwest;
    void Start()
    {
        // Walking = true;
        // body.GetComponent<Rigidbody2D>();

        NextPwest = Pos1[0];
    }

    // Update is called once per frame
    void Update()
    {

        Lakad();
        //sprite.flipX = horizontal > 0 ? false : (horizontal < 0 ? true : sprite.flipX);
    }


   /* void Lakad()
    {
        body.drag = 2f;
        if (Walking == true) { body.transform.Translate(transform.right * horizontal * Time.fixedDeltaTime); }
        
    }*/
    void Lakad()
    {
        if (transform.position == NextPwest.position)
        {
            NextnaPwesto++;
            
            if (NextnaPwesto >= Pos1.Length)
            {
               NextnaPwesto = 0;
            }
            NextPwest = Pos1[NextnaPwesto];

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, NextPwest.position, horizontal * Time.deltaTime);
        }
    }

}