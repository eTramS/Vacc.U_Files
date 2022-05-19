using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour
{
    public Animator crossfade;
    public GameObject Canvasss;
    public float TransPAPA = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if (Input.anyKeyDown)
        {
            StartCoroutine(BackToM());
            Debug.Log("ok");
        }
        
    }

    IEnumerator BackToM()
    {
        
        crossfade.SetTrigger("start");
        Canvasss.SetActive(false);
        yield return new WaitForSeconds(TransPAPA);
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }



}
