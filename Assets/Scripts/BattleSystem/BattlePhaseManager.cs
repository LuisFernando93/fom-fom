using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePhaseManager : MonoBehaviour
{
    public static BattlePhaseManager Instance;
    private string phase;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        phase = "selection";
        Debug.Log(phase);
    }

    public void nextPhase()
    {
        switch (phase)
        {
            case "selection":
                phase = "show";
                break;
            case "show":
                phase = "animate";
                break;
            case "animate":
                phase = "score";
                break;
            case "score":
                phase = "redraw";
                break;
            case "redraw":
                phase = "selection";
                break;
            default:
                Debug.Log("Erro na transicao de turno");
                break;
        }
        Debug.Log(phase);
    }

    public string getCurrentPhase()
    {
        return phase;
    }
}
