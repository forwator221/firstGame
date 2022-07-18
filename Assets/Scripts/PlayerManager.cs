using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Animator animator;
    InputManager inputManager;
    CameraManager cameraManager;
    PlayerLokomotion playerLokomotion;

    InteractableUI interactableUI;
    public GameObject interactableUIGameObject;
    public GameObject interactableItemGameObject;

    public bool isInteracting;
    public bool isUsingRootMotion;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        inputManager = GetComponent<InputManager>();
        cameraManager = FindObjectOfType<CameraManager>();
        playerLokomotion = GetComponent<PlayerLokomotion>();
        interactableUI = FindObjectOfType<InteractableUI>();
    }

    private void Update()
    {
        inputManager.HandleAllInputs();
        CheckForInteractableObject();
    }

    private void FixedUpdate()
    {
        playerLokomotion.HandleAllMovement();
    }

    private void LateUpdate()
    {
        inputManager.lightAttackInput = false;
        inputManager.comboLightAttackInput = false;
        inputManager.arrowUp = false;
        inputManager.arrowDown = false;
        inputManager.arrowLeft = false;
        inputManager.arrowRight = false;
        inputManager.pickUpInput = false;
        inputManager.inventoryInput = false;
        inputManager.unequipAllItemsInput = false;

        cameraManager.HandleAllCameraMovement();

        isInteracting = animator.GetBool("isInteracting");
        isUsingRootMotion = animator.GetBool("isUsingRootMotion");
        playerLokomotion.isJumping = animator.GetBool("isJumping");
        animator.SetBool("isGrounded", playerLokomotion.isGrounded);

    }

    public void CheckForInteractableObject()
    {
        RaycastHit hit;

        if (Physics.SphereCast(transform.position, 0.3f, transform.forward, out hit, 1f, cameraManager.ignoreLayers))
        {
            if (hit.collider.tag == "Interactable")
            {
                Interactable interactableObject = hit.collider.GetComponent<Interactable>();

                if (interactableObject != null)
                {
                    string interactableText = interactableObject.interactableText;
                    interactableUI.interactableText.text = interactableText;
                    interactableUIGameObject.SetActive(true);

                    if (inputManager.pickUpInput)
                    {
                        hit.collider.GetComponent<ItemPickUp>().Interact(this);
                    }
                }
            }
        }
        else
        {
            if (interactableUIGameObject != null)
            {
                interactableUIGameObject.SetActive(false);
            }

            if (interactableItemGameObject != null && inputManager.pickUpInput)
            {
                interactableItemGameObject.SetActive(false);
            }
        }
    }
}
