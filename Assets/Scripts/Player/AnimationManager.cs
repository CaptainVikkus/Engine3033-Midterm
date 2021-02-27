using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator animator;
    private int horizontal;
    private int vertical;

    private void Awake()
    {
        //animator = GetComponent<Animator>();
        horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
        animator.applyRootMotion = false;
    }

    public void UpdateAnimatorMovement(float horizontalBlend, float verticalBlend)
    {
        //Maybe implement snapping here
        animator.SetFloat(horizontal, horizontalBlend, 0.1f, Time.deltaTime);
        animator.SetFloat(vertical, verticalBlend, 0.1f, Time.deltaTime);
    }

}
