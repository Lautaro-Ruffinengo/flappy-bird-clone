using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;
    public int Score {  get { return score; } }


    [SerializeField] GameEventSO gameEventSO;
    [SerializeField] GameEventSO OnScoreUpdatedSO;

    private void Start()
    {
        score = 0;
        
    }
    private void OnEnable()
    {
        gameEventSO.OnEvent += UpdateScore;
    }

    private void OnDisable()
    {
        gameEventSO.OnEvent -= UpdateScore;
    }

    private void UpdateScore()
    {
        score += 1;
        OnScoreUpdatedSO.TriggerEvent();
    }
}
