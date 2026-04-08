using System;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEventSO", menuName = "GameEventSO" )]
public class GameEventSO : ScriptableObject
{
    public Action OnEvent;

    public void TriggerEvent()
    {
        OnEvent?.Invoke();
    }
}
