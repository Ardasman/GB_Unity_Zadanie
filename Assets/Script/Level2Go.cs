using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Go : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup level2Group;


    bool _isPlayerChangeLevel;
    float _timer;

    void Update()
    {
        if (_isPlayerChangeLevel)
        {
            ChangeLevel(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            _isPlayerChangeLevel = true;
        }
    }

    void ChangeLevel(bool goLevel2)
    {
        _timer += Time.deltaTime;

        level2Group.alpha = _timer / fadeDuration;

        if (_timer > fadeDuration + displayImageDuration)

            if (goLevel2)
            {
                SceneManager.LoadScene(2);
            }
    }
}
