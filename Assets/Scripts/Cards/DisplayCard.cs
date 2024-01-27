using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{
    // Start is called before the first frame update
    private List<Card> cards;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject display1, display2, display3, display4;
    [SerializeField] private GameObject gameManager;
    private Card selectedCard = null;

    public void cardClick(int cardIndex)
    {
        selectedCard = cards[cardIndex];
        Debug.Log(selectedCard.getId());
    }

    void Update()
    {
        DisplayHandInUI();
    }

    public void DisplayHandInUI()
    {
        cards = player.GetComponent<HandCards>().getHand();
        display1.GetComponent<Image>().sprite = cards[0].getArtwork();
        display2.GetComponent<Image>().sprite = cards[1].getArtwork();
        display3.GetComponent<Image>().sprite = cards[2].getArtwork();
        display4.GetComponent<Image>().sprite = cards[3].getArtwork();
    }

    public void EndTurn()
    {
        if (selectedCard != null)
        {
            gameManager.GetComponent<GameManager>().setPlayerCard(selectedCard);
            BattlePhaseManager.Instance.nextPhase();
            //selectedCard = null;
        }
    }


}
