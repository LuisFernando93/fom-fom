using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;
    private string phase;
    private bool hasSelected;
    void Update()
    {
        phase = BattlePhaseManager.Instance.getCurrentPhase();
        switch (phase)
        {
            case "selection":
                if (!hasSelected)
                {
                    gameManager.GetComponent<GameManager>().setEnemyCard(gameObject.GetComponent<HandCards>().getRandomCard()) ;
                    hasSelected = true;
                }
                break;
            case "show":
                hasSelected = false;
                break;
            case "animate":
                
                break;
            case "score":
                
                break;
            case "redraw":
                
                break;
            default:
                Debug.Log("Erro na fase de turno");
                break;
        }
    }
}
