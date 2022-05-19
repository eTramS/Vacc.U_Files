using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FakeStage5Planet : MonoBehaviour
{
    public GameObject fakePlanet;
    public GameObject fakeSavep;
    public GameObject warningT;
    public AudioSource ouchsfx;
    public Animator crossfade;
    public GameObject Canvasss;

    // public Canvas cv;

    public float TransPAPA = 5f;

    void Start()
    {
        //fakePlanet.GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ouchsfx.Play();
        Destroy(fakePlanet);
        Destroy(fakeSavep);
        //Destroy(gameObject);
        Destroy(warningT);
       
        StartCoroutine(badEnd());
    }

    IEnumerator badEnd()
    {
       
        crossfade.SetTrigger("start");
        Canvasss.SetActive(false);
        yield return new WaitForSeconds(TransPAPA);
        Time.timeScale = 1f;
        SceneManager.LoadScene(8);
    }



}
