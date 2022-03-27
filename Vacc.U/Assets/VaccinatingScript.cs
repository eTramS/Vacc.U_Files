using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaccinatingScript : MonoBehaviour
{
    private float timeA;
    public float startA;
    public Transform attackp;
    public float attackr;
    public LayerMask Wvaccine;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeA <= 0)
        {
            if (Input.GetKey(KeyCode.G))
            {
                anim.SetTrigger("isVaccinating");
                //Collider2D[] enemytoDamage = Physics2D.OverlapCircleAll(attackp.position,attackr,Wvaccine);            }
                timeA = startA;
            }

            else { timeA -= Time.deltaTime; }
        }
    }
}
