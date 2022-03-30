using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLEVEL2 : MonoBehaviour
{
    public GameObject missingObjective;
    public GameObject EnterStage2;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey("NextLevel");
        missingObjective.SetActive(false);
        EnterStage2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("NextLevel") == 2)
        {
            EnterStage2.SetActive(true);
            missingObjective.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (PlayerPrefs.GetInt("NextLevel") == 2)
            {
                //Scene.Load(1);
                SceneManager.LoadScene(1);

            }
            else
            {
                //Debug.Log("Kulang ka pa gago");
                missingObjective.SetActive(true);
                EnterStage2.SetActive(false);



            }
        }
    }

}
