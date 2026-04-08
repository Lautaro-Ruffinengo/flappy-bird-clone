using System;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] private GameEventSO OnGameOverSO;
    [SerializeField] private GameEventSO OnRestartSO;

    private CanvasGroup canvasGroup;

    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0f;
    }

    private void OnEnable()
    {
        OnGameOverSO.OnEvent += ActivatePanel;
    }

    private void OnDisable()
    {
        OnGameOverSO.OnEvent -= ActivatePanel;
    }

    private void ActivatePanel()
    {
        canvasGroup.alpha = 1.0f;
    }

    public void Restart()
    {
        OnRestartSO.TriggerEvent();
    }
}
