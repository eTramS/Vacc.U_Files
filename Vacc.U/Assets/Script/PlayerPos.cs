using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;

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
            transform.position = gm.lastCheckPointPos;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //
            // GameObject.FindGameObjectWithTag("Player").transform.position


        }

    }

}
