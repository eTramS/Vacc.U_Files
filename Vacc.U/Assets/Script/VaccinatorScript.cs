using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaccinatorScript : MonoBehaviour
{
    
   /* // public Rigidbody2D body;
    public float horizontal = 1f;
    Transform Pos1, Pos2;
    Vector3 localScale;
    bool mRight = true;
    Rigidbody2D body;
    // bool isGrounded;
    // public bool Walking;
    // public SpriteRenderer sprite;
    // Start is called before the first frame update
    //[SerializeField] Transform[] Pos1;
    //[SerializeField] float horizontal;

    //int NextnaPwesto;
    //Transform NextPwest;
    void Start()
    {
        localScale = transform.localScale;
        body = GetComponent<Rigidbody2D>();
        Pos1 = GameObject.Find("Pos1").GetComponent<Transform>();
        Pos2 = GameObject.Find("Pos2").GetComponent<Transform>();
        // Walking = true;
        // body.GetComponent<Rigidbody2D>();

        //NextPwest = Pos1[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > Pos2.position.x)
        {
            mRight = false;
        }
        if (transform.position.x < Pos2.position.x)
        {
            mRight = true;
        }
        if (mRight)
        {
            MoveRight();
        }
        else
        { MoveLeft(); }
        //Lakad();
        //sprite.flipX = horizontal > 0 ? false : (horizontal < 0 ? true : sprite.flipX);
    }


   /* void Lakad()
    {
        body.drag = 2f;
        if (Walking == true) { body.transform.Translate(transform.right * horizontal * Time.fixedDeltaTime); }
        
    }*/
   /* void Lakad()
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
   */
   /*void MoveRight()
    {
        mRight = true;
        localScale.x = 7.175f;
        transform.localScale = localScale;
        body.velocity = new Vector2(localScale.x * horizontal, body.velocity.y);
    }
    void MoveLeft()
    {
        mRight = false;
        localScale.x = -7.175f;
        transform.localScale = localScale;
        body.velocity = new Vector2(localScale.x * horizontal, body.velocity.y);
    }*/
}