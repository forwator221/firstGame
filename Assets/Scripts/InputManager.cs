using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;
    PlayerLokomotion playerLokomotion;
    AnimatorManager animatorManager;

    public Vector2 movementInput;
    public Vector2 cameraInput;

    public float cameraInputX;
    public float cameraInputY;

    public float moveAmount;
    public float vertInput;
    public float horInput;

    public bool sprintInput;
    public bool dodgeInput;
    public bool jumpInput;

    public bool isPaused;

    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
        playerLokomotion = GetComponent<PlayerLokomotion>();
    }

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();

            playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            playerControls.PlayerMovement.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();

            playerControls.PlayerActions.Sprinting.performed += i => sprintInput = true;
            playerControls.PlayerActions.Sprinting.canceled += i => sprintInput = false;
            playerControls.PlayerActions.DodgeBackward.performed += i => dodgeInput = true;
            playerControls.PlayerActions.Jumping.performed += i => jumpInput = true;

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
        HandleSprintingInput();
        HandleJumpingInput();
        HandleDodgeInput();
        //HandleActionInput
    }

    private void HandleMovementInput()
    {
        vertInput = movementInput.y;
        horInput = movementInput.x;

        cameraInputX = cameraInput.x;
        cameraInputY = cameraInput.y;

        moveAmount = Mathf.Clamp01(Mathf.Abs(horInput) + Mathf.Abs(vertInput));
        animatorManager.UpdateAnimatorValues(0, moveAmount, playerLokomotion.isSprinting);
    }

    private void HandleSprintingInput()
    {
        if (sprintInput && moveAmount > 0.5f)
        {
            playerLokomotion.isSprinting = true;
        }
        else
        {
            playerLokomotion.isSprinting = false;
        }
    }

    private void HandleJumpingInput()
    {
        if (jumpInput)
        {
            jumpInput = false;
            playerLokomotion.HandleJumping();
        }
    }

    private void HandleDodgeInput()
    {
        if (dodgeInput)
        {
            dodgeInput = false;
            playerLokomotion.HandleDodge();
        }
    }
}
