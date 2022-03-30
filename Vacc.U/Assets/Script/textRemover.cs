using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textRemover : MonoBehaviour
{
    public GameObject wcTExt;
    public GameObject stageText;
    public GameObject controlText;
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
        if (collision.CompareTag("Player"))
        {
            wcTExt.SetActive(false);
            stageText.SetActive(false);
            controlText.SetActive(false);
        }
    }
}
