using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinovacScript : MonoBehaviour
{
    public int maxHealth=100;
    int currentH;
    public Animator anim;
    bool isGrounded;
    Rigidbody2D body;
    public Sprite estado;
   
    //public Sprite Bakunadona;
    // Start is called before the first frame update
    void Start()
    {
        //anim.SetBool("bakunado", false);
        body = GetComponent<Rigidbody2D>();
        currentH = maxHealth;
        

    }
   
    public void Injection(int turok)
    {
        currentH -= turok;
        //Debug.Log("Hit");
        anim.SetTrigger("binabakunahan");

        if (currentH<=0)
        {
            Bakunado();
           // this.GetComponent<SpriteRenderer>().sprite = Bakunadona;
        }

    }
    void Bakunado()
    {
        anim.SetBool("bakunado", true);

        
       // GetComponent<Collider2D>().isTrigger = true;
        //this.enabled = false;
        
    }
    // Update is called once per frame
    void Update()
    {
        //body.drag = 1.2f;
       
    }

    void OnTriggerStay2D(Collider2D obj)
    {
        if (obj.CompareTag("Planet"))
        {
            body.drag = 5f;

            float distance = Mathf.Abs(obj.GetComponent<GravityPoint>().planetRadius - Vector2.Distance(transform.position, obj.transform.position));
            if (distance < 1f)
            {
                isGrounded = distance < 0.5f;
            }
        }
    }
}
