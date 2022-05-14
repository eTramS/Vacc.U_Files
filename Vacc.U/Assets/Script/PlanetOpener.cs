using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetOpener : MonoBehaviour
{
     //public GameObject wcTExt;
    public GameObject stageText;
    public GameObject peps;
    //public GameObject controlText;
    // Start is called before the first frame update
    void Start()
    {
        stageText.SetActive(false);
        peps.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // wcTExt.SetActive(false);
            stageText.SetActive(true);
            peps.SetActive(true);
            // controlText.SetActive(false);
        }
    }
}
