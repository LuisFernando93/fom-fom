using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    [SerializeField] private List<Card> cardObjects;
    public static List<Card> cardList = new List<Card>();
    public static int nCardList { get; private set; }


    private void Awake()
    {
        foreach (Card card in cardObjects)
        {
            cardList.Add (card);
        }

        nCardList = cardList.Count;
    }

    public static Card findCardById(int id)
    {
        foreach (Card card in CardDatabase.cardList)
        {
            if (card.getId() == id)
            {
                return card;
            }
        }
        return null;
    }
}
