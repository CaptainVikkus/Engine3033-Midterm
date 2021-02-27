using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Animator animator;
    private int horizontal;
    private int vertical;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
    }

    public void UpdateAnimatorMovement(float horizontal, float vertical)
    {
        //Maybe implement snapping here
        animator.SetFloat(this.horizontal, horizontal, 0.1f, Time.deltaTime);
        animator.SetFloat(this.vertical, vertical, 0.1f, Time.deltaTime);
    }

}
