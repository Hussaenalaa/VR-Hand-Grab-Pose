using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public int pointsPerGoal = 1;
    private int _score;

    void Start() => UpdateUI();

    public void AddScore(int amount)
    {
        _score += amount;
        UpdateUI();
    }

    public void ResetScore()
    {
        _score = 0;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (scoreText) scoreText.text = $"Score: {_score}";
    }
}