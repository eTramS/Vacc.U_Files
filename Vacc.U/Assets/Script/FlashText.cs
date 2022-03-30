using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashText : MonoBehaviour
{
    public SpriteRenderer WelcomeText;
    public float interval=2f;
    // Start is called before the first frame update
    void Start()
    {
        WelcomeText.GetComponent<SpriteRenderer>();
       // WelcomeText.color = new Color(255,255,255,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (interval > 0)
        {
            interval -= Time.deltaTime;
            
            
        }
        if (interval<2.6)
        {
            //WelcomeText.SetActive(true);
            WelcomeText.color = new Color(255, 255, 255, 50);
        }
        
    }
}
