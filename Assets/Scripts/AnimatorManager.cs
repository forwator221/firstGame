using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;
    PlayerManager playerManager;
    PlayerLokomotion playerLokomotion;
    int horizontal;
    int vertical;

    public void Awake()
    {
        animator = GetComponent<Animator>();
        playerManager = GetComponent<PlayerManager>();
        playerLokomotion = GetComponent<PlayerLokomotion>();
        horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
    }

    public void PlayTargetAnimation(string targetAnimation, bool isInteracting, bool useRootMotion = false)
    {
        animator.SetBool("isInteracting", isInteracting);
        animator.SetBool("isUsingRootMotion", useRootMotion);
        animator.CrossFade(targetAnimation, 0.2f);
    }

    public void UpdateAnimatorValues(float horMovement, float vertMovement, bool isSprinting)
    {
        //Animation snapping
        float snappedHorizontal;
        float snappedVertical;

        #region Snapped Horizontal 
        if (horMovement > 0 && horMovement < 0.55f)
        {
            snappedHorizontal = 0.5f;
        }
        else if (horMovement > 0.55f)
        {
            snappedHorizontal = 1;
        }
        else if (horMovement < 0 && horMovement > -0.55f)
        {
            snappedHorizontal = -0.5f;
        }
        else if (horMovement <-0.55f)
        {
            snappedHorizontal = -1;
        }
        else
        {
            snappedHorizontal = 0;
        }
        #endregion
        #region Snapped Veritcal 
        if (vertMovement > 0 && vertMovement < 0.55f)
        {
            snappedVertical = 0.5f;
        }
        else if (vertMovement > 0.55f)
        {
            snappedVertical = 1;
        }
        else if (vertMovement < 0 && vertMovement > -0.55f)
        {
            snappedVertical = -0.5f;
        }
        else if (vertMovement < -0.55f)
        {
            snappedVertical = -1;
        }
        else
        {
            snappedVertical = 0;
        }
        #endregion

        if (isSprinting)
        {
            snappedHorizontal = horMovement;
            snappedVertical = 2;
        }

        animator.SetFloat(horizontal, snappedHorizontal, 0.1f, Time.deltaTime);
        animator.SetFloat(vertical, snappedVertical, 0.1f, Time.deltaTime);
    }

    private void OnAnimatorMove()
    {
        if (playerManager.isUsingRootMotion)
        {
            playerLokomotion.playerRigitbody.drag = 0;
            Vector3 deltaPosition = animator.deltaPosition;
            deltaPosition.y = 0;
            Vector3 velocity = deltaPosition / Time.deltaTime;
            playerLokomotion.playerRigitbody.velocity = velocity;
        }
    }
}
