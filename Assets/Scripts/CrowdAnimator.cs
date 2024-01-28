using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdAnimator : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Laugh()
    {
        animator.SetTrigger("laugh");
    }
}
