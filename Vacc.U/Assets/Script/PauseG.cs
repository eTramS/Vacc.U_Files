using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseG : MonoBehaviour
{
    public GameObject PauseCanvaas;
    public GameObject PauseButton;
    public GameObject ResumeButton;
    public Animator transitionPAPA;
   
    //public GameObject canvass;
    public float TransPAPA = 2f;
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
            { Pause();  }
           


        }

    }
    public void GPause()
    {
        Pause();

    }
    public void GResume()
    {
        Resume_();
  
    }

    void Pause()
    {
        AudioListener.pause = true;


        
        PauseButton.SetActive(false); ResumeButton.SetActive(true);
        PauseCanvaas.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Resume_()
    {
        AudioListener.pause = false;


        PauseButton.SetActive(true); ResumeButton.SetActive(false);
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
