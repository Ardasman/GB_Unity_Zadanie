using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitGroup;
   

    bool _isPlayerWin;
    float _timer;

    void Update()
    {

        if (_isPlayerWin)
        {
            EndLevel(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            _isPlayerWin = true;
        }
    }

    void EndLevel(bool doRestart)
    {
        _timer += Time.deltaTime;

            exitGroup.alpha = _timer / fadeDuration;

        if (_timer > fadeDuration + displayImageDuration)

            if (doRestart)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                Application.Quit();
            }
    }
}
