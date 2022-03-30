using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public void _Start()
    {
        PlayerPrefs.DeleteKey("NextLevel");
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }
}
