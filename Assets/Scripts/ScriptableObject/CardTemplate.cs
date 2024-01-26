using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card Template")]
public class CardTemplate : ScriptableObject
{
    public Sprite artwork;
    public string cardName;
    public int id;
    public CardType type;
}
