using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class HandCards : MonoBehaviour
{
    private List<Card> cards = new List<Card>();
    [SerializeField] int nHandCards;

    // Start is called before the first frame update
    void Start()
    {
        drawHand();
    }

    public List<Card> getHand()
    {
        return cards;
    }

    public void drawHand()
    {
        cards = new List<Card>();
        for (int i = 0; i < nHandCards; i++)
        {
            drawCard();
        }
    }

    public void removeCard(Card card)
    {
        cards.Remove(card);
    }

    public void drawCard()
    {
        Card card = CardDatabase.findCardById(Random.Range(0, CardDatabase.nCardList));
        if (card != null)
        {
            cards.Add(card);
        }
    }
}
