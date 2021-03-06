using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed=5f, jumpPower=8f;
    public SpriteRenderer sprite;
    public GameObject Player0;
    public Vector3 localScale;
    public ParticleSystem dust;
    public ParticleSystem dust1;
    private GameMaster gm;

    [SerializeField] private AudioSource ouchSFX;
    [SerializeField] private AudioSource jumpingS;
    [SerializeField] private AudioSource walkingS;
    //public Transform bod;
    Rigidbody2D body;
    bool isGrounded;
    float horizontal;
    
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {//input
        horizontal = Input.GetAxisRaw("Horizontal");
        //jumping script
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("isJumping");
            body.AddForce(transform.up * jumpPower, ForceMode2D.Impulse);
            DustJump();
            jumpingS.Play();
            
            
            //body.AddForce(transform.right*horizontal*3f,ForceMode2D.Impulse);

        }
        //attack script
        

        //Player0.transform.localScale = new Vector3(-0.10f, .10f, 0.11f);


    }
    protected void LateUpdate()
    {
        transform.localEulerAngles = new Vector3(0, 0, transform.localEulerAngles.z);
    }
    // Walking script and animator 
    void FixedUpdate()
    {
        if (isGrounded)
        {
            body.AddForce(transform.right* horizontal * moveSpeed);
            if (horizontal == 0)
            {
                //anim.SetBool("isJumping", false);
                anim.SetBool("isWalking", false);
                //transform.rotation = Quaternion.Euler(0f,0f,0f);
                body.constraints = RigidbodyConstraints2D.FreezeRotation;
                
                walkingS.Play();
                //Player0.transform.localScale = new Vector3(-0.10f, .10f, 0.11f);
            }
            else
            {
               // anim.SetBool("isJumping", false);
                anim.SetBool("isWalking", true);
                body.constraints = RigidbodyConstraints2D.None;
                DustWalk();
               
                // Player0.transform.localScale = new Vector3(-0.10f, .10f, 0.11f);

            }

            
        }
        //flip
        if (horizontal > 0) { Player0.transform.localScale = new Vector3(0.10f, .10f, 0);  }
        if (horizontal < 0) { Player0.transform.localScale = new Vector3(-0.10f, .10f, 0);  }
        
       // sprite.flipX = horizontal > 0 ? false : (horizontal < 0 ? true : sprite.flipX);
        //  transform.Translat = horizontal > 0 ? false : (horizontal < 0 ? true : sprite.flipX);

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
        if (obj.tag == "Rock")
        {

            ouchSFX.Play();
            body.constraints = RigidbodyConstraints2D.FreezeAll;
            transform.position = gm.lastCheckPointPos;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //
            // GameObject.FindGameObjectWithTag("Player").transform.position


        }
    }

    void OnTriggerExit2D(Collider2D obj)
    {
        if (obj.CompareTag("Planet"))
        {
            body.drag = 0.5f;
        }
    }
   void DustJump()
    {
        dust.Play();
    }
    void DustWalk()
    {
        dust1.Play();
    }

}
