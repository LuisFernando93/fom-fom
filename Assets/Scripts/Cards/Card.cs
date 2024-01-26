using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card Template")]
public class Card: ScriptableObject
{
    [SerializeField] private Sprite artwork;
    [SerializeField] private string cardName;
    [SerializeField] private int id;
    [SerializeField] private CardType cardType;
    [SerializeField] private int power;

    public Sprite getArtwork()
    {
        return this.artwork; 
    }

    public string getCardName()
    {
        return this.cardName;
    }

    public int getId()
    {
        return this.id;
    }

    public CardType getCardType()
    {
        return this.cardType;
    }

    public int getPower()
    {
        return this.power; 
    }

}
