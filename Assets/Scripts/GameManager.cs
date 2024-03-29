using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private AudioClip music;
    [SerializeField] private GameObject playerHandUI;
    [SerializeField] private GameObject showSelectedCardsUI;
    [SerializeField] private GameObject playerDisplay, enemyDisplay;
    [SerializeField] private GameObject player, enemy;
    [SerializeField] private GameObject popularityBar;
    [SerializeField] private GameObject crowd;
    private Card enemyCard, playerCard;
    private string phase;
    private int round;
    private bool isShowing = false;
    private bool isAnimating = false;

    void Start()
    {
        SoundManager.Instance.PlayMusic(music);
        round = 1;
        enemy.GetComponent<HandCards>().drawHand();
        player.GetComponent<HandCards>().drawHand();
    }

    // Update is called once per frame
    void Update()
    {
        checkRound();
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
                if(!isAnimating)
                {
                    StartCoroutine(animatePhase());
                    isAnimating = true;
                }
                break;
            case "score":
                scorePhase();
                break;
            case "redraw":
                redrawPhase();
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
        yield return new WaitForSeconds(3);
        showSelectedCardsUI.SetActive(false);
        BattlePhaseManager.Instance.nextPhase();
        isShowing = false;
        yield break;
    }

    private IEnumerator animatePhase()
    {
        playerHandUI.SetActive(false);
        player.GetComponent<CharacterAnimator>().playCardAnimation(playerCard);
        enemy.GetComponent<CharacterAnimator>().playCardAnimation(enemyCard);
        yield return new WaitForSeconds(2);
        crowd.GetComponent<CrowdAnimator>().Laugh();
        yield return new WaitForSeconds(1);
        BattlePhaseManager.Instance.nextPhase();
        isAnimating = false;
        yield break;
    }

    private void scorePhase()
    {
        playerHandUI.SetActive(false);
        popularityBar.GetComponent<Popularity>().AddPlayerPopularity(playerCard.getPower());
        popularityBar.GetComponent<Popularity>().AddEnemyPopularity(enemyCard.getPower());
        BattlePhaseManager.Instance.nextPhase();
    }

    private void redrawPhase()
    {
        round++;
        Debug.Log("Round: " + round);
        playerHandUI.SetActive(false);
        enemy.GetComponent<HandCards>().drawHand();
        player.GetComponent<HandCards>().drawHand();
        BattlePhaseManager.Instance.nextPhase();
    }

    private void checkRound()
    {
        if (round > 5)
        {
            int score = popularityBar.GetComponent<Popularity>().getPopularityScore();
            if(score > 0)
            {
                SceneManager.LoadScene("Victory");
            } else
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
