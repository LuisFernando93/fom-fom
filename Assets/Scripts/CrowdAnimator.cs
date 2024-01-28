using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdAnimator : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private AudioClip laugh, applaud;
    

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Laugh()
    {
        animator.SetTrigger("laugh");
    }

    public void playSFX()
    {
        if(Random.Range(0,2) == 0)
        {
            SoundManager.Instance.PlaySFX(laugh);
        } else
        {
            SoundManager.Instance.PlaySFX(applaud);
        }

    }

    public void stopSFX()
    {
        SoundManager.Instance.StopSFX();
    }
}
