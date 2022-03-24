using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed=10f, jumpPower=10f;
    public SpriteRenderer sprite;
    public GameObject Player0;
    public Vector3 localScale;

    Rigidbody2D body;
    bool isGrounded;
    float horizontal;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
           body.AddForce(transform.up * jumpPower, ForceMode2D.Impulse);
            //body.AddForce(transform.right*horizontal*3f,ForceMode2D.Impulse);

        }
        //Player0.transform.localScale = new Vector3(-0.10f, .10f, 0.11f);
        

    }

    void FixedUpdate()
    {
        if (isGrounded)
        {
            body.AddForce(transform.right* horizontal * moveSpeed);
            if (horizontal == 0)
            {
                anim.SetBool("isWalking", false);
                //Player0.transform.localScale = new Vector3(-0.10f, .10f, 0.11f);
            }
            else
            {
                anim.SetBool("isWalking", true);
               // Player0.transform.localScale = new Vector3(-0.10f, .10f, 0.11f);

            }
        }
        sprite.flipX = horizontal > 0 ? false : (horizontal < 0 ? true : sprite.flipX);
    }

    void OnTriggerStay2D(Collider2D obj)
    {
        if (obj.CompareTag("Planet"))
        {
            body.drag = 1.2f;

            float distance = Mathf.Abs(obj.GetComponent<GravityPoint>().planetRadius - Vector2.Distance(transform.position, obj.transform.position));
            if (distance < 1f)
            {
                isGrounded = distance < 0.5f;
            }
        }
    }

    void OnTriggerExit2D(Collider2D obj)
    {
        if (obj.CompareTag("Planet"))
        {
            body.drag = 0.5f;
        }
    }
}
