using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
    [SerializeField] private AudioClip fomfom;
    [SerializeField] private AudioClip flower;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void playCardAnimation(Card card)
    {
        switch (card.getId())
        {
            case 0:
                animator.SetTrigger("fomfom");
                break;
            case 1:
                animator.SetTrigger("flower");
                break;
            case 2:
                animator.SetTrigger("joke");
                break;
            case 3:
                animator.SetTrigger("pie");
                break;
            case 4:
                animator.SetTrigger("makefunof");
                break;
            case 5:
                animator.SetTrigger("ignore");
                break;
            case 6:
                animator.SetTrigger("silence");
                break;
            case 7:
                animator.SetTrigger("boh");
                break;
            case 8:
                animator.SetTrigger("balance");
                break;
            case 9:
                animator.SetTrigger("timeout");
                break;
            case 10:
                animator.SetTrigger("think");
                break;
            default:
                Debug.Log("Erro no codigo de animacao");
                break;
        }
    }

    public void playfomfomSFX()
    {
        SoundManager.Instance.PlaySFX(fomfom);
    }

    public void playflowerSFX()
    {
        SoundManager.Instance.PlaySFX(flower);
    }
}
