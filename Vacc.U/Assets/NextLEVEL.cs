using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLEVEL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (PlayerPrefs.GetInt("NextLevel") == 1)
            {
                //Scene.Load(1);
                SceneManager.LoadScene(3);
            }
            else { Debug.Log("Kulang ka pa gago"); }
        }
    }
}
