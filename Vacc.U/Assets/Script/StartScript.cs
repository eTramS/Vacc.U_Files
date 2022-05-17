using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public Animator crossfade;
    public GameObject Canvasss;
   
   // public Canvas cv;
   
    public float TransPAPA = 2f;
    public void Start()
    {
        Canvasss.SetActive(true);
        Time.timeScale = 1f;
       
    }
    public void _Start()
    {
        
        StartCoroutine(startlvl());
        
      
    }

    public void About()
    {

        StartCoroutine(About_());


    }
    public void MAINMENU()
    {

        StartCoroutine(BackToM());


    }
    public void QUITg()
    {
        Application.Quit();
    }

    IEnumerator startlvl()
    {
        PlayerPrefs.DeleteKey("NextLevel");
        crossfade.SetTrigger("start");
       Canvasss.SetActive(false);
        yield return new WaitForSeconds(TransPAPA);
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }
    IEnumerator About_()
    {
        PlayerPrefs.DeleteKey("NextLevel");
        crossfade.SetTrigger("start");
        Canvasss.SetActive(false);
        yield return new WaitForSeconds(TransPAPA);
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }
    IEnumerator BackToM()
    {
        PlayerPrefs.DeleteKey("NextLevel");
        crossfade.SetTrigger("start");
        Canvasss.SetActive(false);
        yield return new WaitForSeconds(TransPAPA);
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}
