using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    Animator animator;
    int horizontal;
    int vertical;

    public void Awake()
    {
        animator = GetComponent<Animator>();
        horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
    }

    public void UpdateAnimatorValues(float horMovement, float vertMovement)
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

        animator.SetFloat(horizontal, snappedHorizontal, 0.1f, Time.deltaTime);
        animator.SetFloat(vertical, snappedVertical, 0.1f, Time.deltaTime);
    }
}
