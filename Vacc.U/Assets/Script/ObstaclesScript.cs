using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstaclesScript : MonoBehaviour
    
{
    private GameMaster gm;
    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //player.GetComponent<Collider2D>();
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("Hit");

        if (collision.tag== "Player" ) 
        { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
             }
        
    }
}

