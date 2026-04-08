using System;
using UnityEngine;
using UnityEngine.SceneManagement;


//Set and communicate game state changes
public class GameManager : MonoBehaviour
{
    [SerializeField] private GameEventSO OnPlayerDiedSO;
    [SerializeField] private GameEventSO OnGameOverSO;
    [SerializeField] private GameEventSO OnRestartSO;

    private void Start()
    {
        OnPlayerDiedSO.OnEvent += GameOver;
        OnRestartSO.OnEvent += Restart;
    }

    private void OnDisable()
    {
        OnPlayerDiedSO.OnEvent -= GameOver;
        OnRestartSO.OnEvent -= Restart;
    }

    private void GameOver()
    {
        Time.timeScale = 0;
        OnGameOverSO.TriggerEvent();
    }

    private void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
