using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private InputAction jumpAction;
    private InputAction moveAction;

    private void Start()
    {
        jumpAction = InputSystem.actions.FindAction("jump");
        moveAction = InputSystem.actions.FindAction("move");
    }


    private void Update()
    {
        if(jumpAction.triggered)
        {
            Debug.Log("ƒWƒƒƒ“ƒv‚µ‚½‚æ");
        }

        Vector2 moveInput = moveAction.ReadValue<Vector2>();
    }
}