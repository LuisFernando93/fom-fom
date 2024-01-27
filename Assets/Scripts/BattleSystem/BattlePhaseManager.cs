using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePhaseManager : MonoBehaviour
{
    public static BattlePhaseManager Instance;
    private string phase;
    [SerializeField] private GameObject playerHandUI;

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

    // Update is called once per frame
    void Update()
    {
        switch (phase)
        {
            case "selection":
                playerHandUI.SetActive(true);
                break;
            case "show":
                playerHandUI.SetActive(false);
                break;
            case "animate":
                playerHandUI.SetActive(false);
                break;
            case "score":
                playerHandUI.SetActive(false);
                break;
            case "redraw":
                playerHandUI.SetActive(false);
                break;
            default:
                Debug.Log("Erro na transicao de turno");
                break;
        }
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
}
