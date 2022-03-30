using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2Flasher : MonoBehaviour
{
    public GameObject stage2Text;
    public float interval = 4f;
    // Start is called before the first frame update
    void Start()
    {
        stage2Text.SetActive(true);

        // WelcomeText.color = new Color(255,255,255,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (interval > 0)
        {
            interval -= Time.deltaTime;


        }
        else
        {
            //WelcomeText.SetActive(true);
            stage2Text.SetActive(false);
           
        }

    }
}
