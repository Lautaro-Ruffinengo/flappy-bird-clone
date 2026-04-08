using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;
    public int Score {  get { return score; } }


    [SerializeField] GameEventSO gameEventSO;

    private void Start()
    {
        score = 0;
        gameEventSO.OnEvent += UpdateScore;
    }

    private void OnDisable()
    {
        gameEventSO.OnEvent -= UpdateScore;
    }

    private void UpdateScore()
    {
        score += 1;
        Debug.Log(score);
    }
}
