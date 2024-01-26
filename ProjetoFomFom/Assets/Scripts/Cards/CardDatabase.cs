using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    [SerializeField] private List<Card> cardObjects;
    public static List<Card> cardList = new List<Card> ();


    private void Awake()
    {
        foreach (Card card in cardObjects)
        {
            cardList.Add (card);
        }
    }
}
