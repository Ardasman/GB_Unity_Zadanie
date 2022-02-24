using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuOpen : MonoBehaviour
{
    public bool isOpened = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            //ShowHideMenu();
            GoToMain();
        }
    }

    public void GoToMain()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 0f;
    }

}
