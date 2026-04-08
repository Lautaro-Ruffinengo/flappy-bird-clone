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
        gameEventSO.OnPointScored += UpdateScore;
    }

    private void UpdateScore(object sender, EventArgs e)
    {
        score += 1;
        Debug.Log(score);
    }
}
