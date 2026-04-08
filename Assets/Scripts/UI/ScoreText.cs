using System;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private GameEventSO OnScoreUpdatedSO;
    [SerializeField] private ScoreManager scoreManager;

    private TextMeshProUGUI scoreText;


    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = "SCORE: " + 0;
    }
    private void OnEnable()
    {
        OnScoreUpdatedSO.OnEvent += UpdateScoreText;
    }

    private void OnDisable()
    {
        OnScoreUpdatedSO.OnEvent -= UpdateScoreText;
    }

    private void UpdateScoreText()
    {
        scoreText.text = "SCORE: " + scoreManager.Score;
    }
}
