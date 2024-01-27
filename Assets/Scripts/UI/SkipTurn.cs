using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipTurn : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(SkipTurnButton);
    }

    void SkipTurnButton(){
        
        HandCards handCards = FindObjectOfType<HandCards>();

        handCards.SkipTurn();
    }
}
