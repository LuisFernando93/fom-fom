using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private AudioClip music;
    [SerializeField] private GameObject playerHandUI;
    [SerializeField] private GameObject showSelectedCardsUI;
    [SerializeField] private GameObject playerDisplay, enemyDisplay;
    private Card enemyCard, playerCard;
    private string phase;
    private bool isShowing = false;

    void Start()
    {
        SoundManager.Instance.PlayMusic(music);
    }

    // Update is called once per frame
    void Update()
    {
        phase = BattlePhaseManager.Instance.getCurrentPhase();
        switch (phase)
        {
            case "selection":
                playerHandUI.SetActive(true);
                break;
            case "show":
                if (!isShowing)
                {
                    StartCoroutine(showPhase());
                    isShowing = true;
                }
                break;
            case "animate":
                playerHandUI.SetActive(false);
                break;
            case "score":
                playerHandUI.SetActive(false);
                break;
            case "redraw":
                playerHandUI.SetActive(false);
                break;
            default:
                Debug.Log("Erro na transicao de turno");
                break;
        }
    }

    public void setPlayerCard(Card card)
    {
        playerCard = card;
    }

    public void setEnemyCard(Card card)
    {
        enemyCard = card;
    }

    private IEnumerator showPhase()
    {
        playerHandUI.SetActive(false);
        showSelectedCardsUI.SetActive(true);
        playerDisplay.GetComponent<Image>().sprite = playerCard.getArtwork();
        enemyDisplay.GetComponent<Image>().sprite = enemyCard.getArtwork();
        yield return new WaitForSeconds(5);
        showSelectedCardsUI.SetActive(false);
        BattlePhaseManager.Instance.nextPhase();
        isShowing = false;
        yield break;
    }
}
