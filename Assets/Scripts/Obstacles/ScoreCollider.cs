using System;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreCollider : MonoBehaviour
{
    [SerializeField] GameEventSO gameEventSO;

    private BoxCollider2D _boxCollider2D;

    private void Start()
    {
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameEventSO.TriggerEvent();
        }
    }

}
