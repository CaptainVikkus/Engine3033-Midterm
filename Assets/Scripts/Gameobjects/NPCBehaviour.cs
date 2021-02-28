using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehaviour : MonoBehaviour
{
    public Animator animator;
    private int talked;

    public Canvas message;
    private int playerLayer;

    private void Start()
    {
        talked = Animator.StringToHash("Talked");
        playerLayer = LayerMask.NameToLayer("Player");
        message.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.layer == playerLayer)
        {
            Debug.Log("HI " + other.gameObject.layer + " VS " + playerLayer);
            animator.SetBool(talked, true);
            message.enabled = true;
        }
    }
}
