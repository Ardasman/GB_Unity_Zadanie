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

    private AudioSource _audioSource;

    bool _isPlayerWin;
    float _timer;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

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
            _audioSource.Play();
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
