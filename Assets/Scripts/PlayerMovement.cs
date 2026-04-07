using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private InputActionReference jumpAction;

    [SerializeField] private float jumpForce;
    

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
        _rb.linearVelocityY = jumpForce;
        Debug.Log("Jumping!");
    }
}
