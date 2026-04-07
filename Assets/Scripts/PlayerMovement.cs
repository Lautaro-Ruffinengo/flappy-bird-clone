using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private InputActionReference jumpAction;

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
        Debug.Log("Jumping!");
    }
}
