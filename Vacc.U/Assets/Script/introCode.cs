using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introCode : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float wait_time = 5f;


    void Start()
    {
        StartCoroutine(introWait());
    }

    IEnumerator introWait()
    {
        yield return new WaitForSeconds(wait_time);
        //load animated start screen
        SceneManager.LoadScene(1);
    }



}
