using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealthController : MonoBehaviour
{
    public float healthBase;
    public float healthCurrent;
    public int scoreForKill;

    public TextMeshProUGUI scoreText;

    private int score;

    void Start()
    {
        
        SetHealth();

        score = 0;
        UpdateScore(score);

    }

    public void SetHealth()
    {
        healthCurrent = healthBase;
    }

    public void TakeDamage(float amountDamage)
    {
        healthCurrent -= amountDamage;
        if (healthCurrent <= 0)
        {
            Destroy(gameObject);
            UpdateScore(scoreForKill);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
