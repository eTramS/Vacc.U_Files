using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;
   
    [SerializeField] private AudioSource ouchSFX;
     void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        //transform.position = gm.lastCheckPointPos;

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("Hit");

        if (collision.tag == "Rock")
        {
            ouchSFX.Play();
            transform.position = gm.lastCheckPointPos;
            
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //
            // GameObject.FindGameObjectWithTag("Player").transform.position


        }

    }

}
