using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Animator animator;
    InputManager inputManager;
    CameraManager cameraManager;
    PlayerLokomotion playerLokomotion;

    public bool isInteracting;
    public bool isUsingRootMotion;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        inputManager = GetComponent<InputManager>();
        cameraManager = FindObjectOfType<CameraManager>();
        playerLokomotion = GetComponent<PlayerLokomotion>();
    }

    private void Update()
    {
        inputManager.HandleAllInputs();
    }

    private void FixedUpdate()
    {
        playerLokomotion.HandleAllMovement();
    }

    private void LateUpdate()
    {
        inputManager.lightAttackInput = false;
        inputManager.comboLightAttackInput = false;

        cameraManager.HandleAllCameraMovement();

        isInteracting = animator.GetBool("isInteracting");
        isUsingRootMotion = animator.GetBool("isUsingRootMotion");
        playerLokomotion.isJumping = animator.GetBool("isJumping");
        animator.SetBool("isGrounded", playerLokomotion.isGrounded);

    }
}
