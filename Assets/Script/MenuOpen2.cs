using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuOpen2 : MonoBehaviour
{
    public bool isOpened = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            GoToMain();
        }
    }

    public void GoToMain()
    {
        SceneManager.LoadScene("Level_1");
        Time.timeScale = 1f;
    }
}
