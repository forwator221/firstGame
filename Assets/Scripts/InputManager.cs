using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;
    AnimatorManager animatorManager;

    public Vector2 movementInput;
    public float moveAmount;
    public float vertInput;
    public float horInput;

    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
    }

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();

            playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
        }

        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public void HandleAllInputs()
    {
        HandleMovementInput();
        //HandleActionInput
        //HandeJumpInput
        //HandeRunInput
    }

    private void HandleMovementInput()
    {
        vertInput = movementInput.y;
        horInput = movementInput.x;
        moveAmount = Mathf.Clamp01(Mathf.Abs(horInput) + Mathf.Abs(vertInput));
        animatorManager.UpdateAnimatorValues(0, moveAmount);
    }
}
