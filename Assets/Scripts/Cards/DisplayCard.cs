using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int id = Random.Range(0, 3);
        Card card = findCardById(id);

        if (card != null)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = card.getArtwork();
        }
    }

    public Card findCardById(int id)
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
