using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public void _Start()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }
}
