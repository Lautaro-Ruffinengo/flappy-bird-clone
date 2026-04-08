using System;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEventSO", menuName = "GameEventSO" )]
public class GameEventSO : ScriptableObject
{
    public event EventHandler OnPointScored;

    public void TriggerEvent()
    {
        OnPointScored?.Invoke(this, EventArgs.Empty);
    }
}
