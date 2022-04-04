using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinovacScript : MonoBehaviour
{
    public int maxHealth = 50;
    int currentH;
    public Animator anim;
    bool isGrounded;
    Rigidbody2D body;
    public Sprite estado;
    [SerializeField] private AudioSource bakunadoS;
    // public int Tao;


    //public GameObject[] Babakunahan;
    //public GameObject[] BAKUNADA;

    //public Sprite Bakunadona;
    // Start is called before the first frame update
    void Start()
    {
        //anim.SetBool("bakunado", false);
        body = GetComponent<Rigidbody2D>();
        currentH = maxHealth;
        anim.SetBool("bakunado", false);
        //Babakunahan = GetComponent<GameObject>();

        

     

    }
    void Update()
    {
        //body.drag = 1.2f;
     /*   if (Tao < 1)
        {
            Destroy(Babakunahan[0].gameObject);
            BAKUNADA[0].SetActive(true);
        }
        else if (Tao < 2)
        {
            Destroy(Babakunahan[1].gameObject);
            BAKUNADA[1].SetActive(true);

        }
        else if (Tao < 3)
        {
            Destroy(Babakunahan[2].gameObject);
            BAKUNADA[2].SetActive(true);
        }
        else if (Tao < 4)
        {
            Destroy(Babakunahan[3].gameObject);
            BAKUNADA[3].SetActive(true);
        }
        else if (Tao < 5)
        {
            Destroy(Babakunahan[4].gameObject);
            BAKUNADA[4].SetActive(true);
        }
        else if (Tao < 6)
        {
            Destroy(Babakunahan[5].gameObject);
            BAKUNADA[5].SetActive(true);
        }*/
    }

    public void Injection(int turok)
    {
        if (currentH > 0)
        {
            currentH -= turok;
           
            //Debug.Log("Hit");
            anim.SetTrigger("binabakunahan");
        }
      
        if (currentH<=0)
        {
           // Tao -= turok;
            Bakunado();
           // this.GetComponent<SpriteRenderer>().sprite = Bakunadona;
        }
        else anim.SetBool("bakunado", true);

    }
    
    void Bakunado()
    {
        anim.SetBool("bakunado", true);
        bakunadoS.Play();
       
        GetComponent<Collider2D>().enabled = false;
        this.GetComponent<Rigidbody2D>().constraints= RigidbodyConstraints2D.FreezeAll;

    }
    // Update is called once per frame
  
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
