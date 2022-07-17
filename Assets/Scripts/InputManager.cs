using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;
    PlayerAttacker playerAttacker;
    Inventory inventory;
    PlayerLokomotion playerLokomotion;
    AnimatorManager animatorManager;
    PlayerManager playerManager;
    //UIManager uiManager;

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
    public bool arrowUp;
    public bool arrowDown;
    public bool arrowRight;
    public bool arrowLeft;
    public bool pickUpInput;
    public bool inventoryInput;

    public bool lightAttackInput;
    public bool comboLightAttackInput;

    public bool isPaused;
    public bool inInventory;

    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
        playerManager = GetComponent<PlayerManager>();
        playerLokomotion = GetComponent<PlayerLokomotion>();
        playerAttacker = GetComponent<PlayerAttacker>();
        inventory = GetComponent<Inventory>();
        //uiManager = FindObjectOfType<UIManager>();
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
        //HandleAttackInput();
        //HandleQuickSlotsInput();
        HandleInteractingButtonInput();
        HandleInventoryInput();
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

    //private void HandleAttackInput()
    //{
    //    playerControls.PlayerActions.LightAttack.performed += i => lightAttackInput = true;
    //    playerControls.PlayerActions.ComboLightAttack.performed += i => comboLightAttackInput = true;

    //    if (lightAttackInput)
    //    {
    //        if (playerManager.isInteracting)
    //            return;

    //        playerAttacker.HandleLightAttack(playerInventory.rightWeapon);
    //    }
    //    if (comboLightAttackInput)
    //    {
    //        playerAttacker.HandleComboLightAttack(playerInventory.rightWeapon);
    //    }
    //}

    //private void HandleQuickSlotsInput()
    //{
    //    playerControls.QuckSlots.DPadRight.performed += i => arrowRight = true;
    //    playerControls.QuckSlots.DPadLeft.performed += i => arrowLeft = true;
    //    if (arrowRight)
    //    {
    //        playerInventory.ChangeWeaponInRightHand();
    //    }
    //    else if(arrowLeft)
    //    {
    //        playerInventory.ChangeWeaponInLeftHand();
    //    }
    //}

    private void HandleInteractingButtonInput()
    {
        playerControls.PlayerActions.PickUp.performed += i => pickUpInput = true;
    }

    private void HandleInventoryInput()
    {
        playerControls.PlayerActions.Inventory.performed += i => inventoryInput = true;

        if (inventoryInput)
        {
            inInventory = !inInventory;

            if (inInventory)
            {
                Time.timeScale = 0;
                //uiManager.OpenSelectedWindow();
                //uiManager.UpdateUI();
                //uiManager.hudWindow.SetActive(false);
            }
            else
            {
                Time.timeScale = 1;
                //uiManager.CloseSelectedWindow();
                //uiManager.CloseAllInventoryWindows();
                //uiManager.hudWindow.SetActive(true);
            }
        }
    }


}
