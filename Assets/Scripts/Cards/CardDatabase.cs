using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card> ();


    public void AddCard(Card card)
    {
        cardList.Add(card);
    }
}
