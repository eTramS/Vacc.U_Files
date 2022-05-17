using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseG : MonoBehaviour
{
    public GameObject PauseCanvaas;
    public Animator transitionPAPA;
    //public GameObject canvass;
    public float TransPAPA = .5f;
    public static bool GameIsPaused = false;

    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            { Resume_(); }
            else 
            { Pause(); }
           


        }

    }

    void Pause()
    {
        PauseCanvaas.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Resume_()
    {
        PauseCanvaas.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
   public void Home_()
    {
        SceneManager.LoadScene(1);
        //StartCoroutine(Load1());
    }

    IEnumerator Load1()
    {
        transitionPAPA.SetTrigger("start");
       // PauseCanvaas.SetActive(false);
        yield return new WaitForSeconds(TransPAPA);
     //  Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }


}
