using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public float speed = 10.0f;
    private Vector2 moveDirection;

    public void OnMove(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();
    }

    void Update()
    {
        transform.position += new Vector3(moveDirection.x, moveDirection.y, 0.0f) * speed * Time.deltaTime;
    }
}
