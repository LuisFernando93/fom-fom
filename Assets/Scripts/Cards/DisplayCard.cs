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

    private void Start()
    {

    }

    void Update()
    {
        DisplayHandInUI();
    }

    public void DisplayHandInUI()
    {
        cards = player.GetComponent<HandCards>().getHand();
        Debug.Log(cards.Count);
        display1.GetComponent<Image>().sprite = cards[0].getArtwork();
        display2.GetComponent<Image>().sprite = cards[1].getArtwork();
        display3.GetComponent<Image>().sprite = cards[2].getArtwork();
        display4.GetComponent<Image>().sprite = cards[3].getArtwork();
    }

}
