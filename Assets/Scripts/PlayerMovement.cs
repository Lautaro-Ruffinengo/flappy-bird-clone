using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public event EventHandler OnDead;

    [SerializeField] private InputActionReference jumpAction;

    [SerializeField] private GameConfigSO GameConfigSO;
    

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        jumpAction.action.performed += Jump;
    }

    private void OnDisable()
    {
        jumpAction.action.performed -= Jump;
    }

    private void Jump(InputAction.CallbackContext context)
    {
        _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, GameConfigSO.jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            OnDead?.Invoke(this, EventArgs.Empty);
        }
    }

}
