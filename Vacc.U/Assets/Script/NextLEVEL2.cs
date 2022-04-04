using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLEVEL2 : MonoBehaviour
{
    public Animator transitionPAPA;
    public float TransPAPA = 3f;
    public GameObject missingObjective;
    public GameObject EnterStage2;
    [SerializeField] private AudioSource NextlevelSFX;
    [SerializeField] private AudioSource failedSFX;
    public GameObject canvass;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey("NextLevel");
        missingObjective.SetActive(false);
        EnterStage2.SetActive(false);
        canvass.SetActive(true);
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
                
                StartCoroutine(LOADleve2());
            }
            else
            {
                //Debug.Log("Kulang ka pa gago");
                missingObjective.SetActive(true);
                failedSFX.Play();
                EnterStage2.SetActive(false);



            }
        }
    }


    IEnumerator LOADleve2()
    {
        canvass.SetActive(true);
        NextlevelSFX.Play();
        transitionPAPA.SetTrigger("start");
        yield return new WaitForSeconds(TransPAPA);
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

}
