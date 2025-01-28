using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    private Transform playerPosition;
    private Vector2 moveDirection;
    public float moveSpeed = 0.1f;

    private void Start()
    {
        playerPosition = gameObject.GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        playerPosition.position += (Vector3)(moveDirection * moveSpeed);
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();
    }
}
