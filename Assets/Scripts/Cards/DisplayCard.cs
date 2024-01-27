using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{
    // Start is called before the first frame update
    private List<Card> cards;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject display1, display2, display3, display4;

    private void Start()
    {
        AddClickEvent(display1, 0);
        AddClickEvent(display2, 1);
        AddClickEvent(display3, 2);
        AddClickEvent(display4, 3);
    }

        void AddClickEvent(GameObject cardDisplay, int cardIndex)
    {

        Button button = cardDisplay.GetComponent<Button>();
        if (button == null)
        {
            button = cardDisplay.AddComponent<Button>();
        }

        button.onClick.AddListener(() => OnCardClick(cardIndex));
    }

        void OnCardClick(int cardIndex)
    {

        if (cardIndex >= 0 && cardIndex < cards.Count)
        {
            int cardID = cards[cardIndex].getId();

            switch (cardID)
            {
                case 0:
                    Debug.Log(" teste0.");
                    break;
                case 1:
                    Debug.Log(" teste1.");
                    break;
                case 2:
                    Debug.Log(" teste2.");
                    break;
                case 3:
                    Debug.Log(" teste3.");
                    break;
                case 4:
                    Debug.Log(" teste4.");
                    break;
                case 5:
                    Debug.Log(" teste5.");
                    break;
                case 6:
                    Debug.Log(" teste6.");
                    break;
                case 7:
                    Debug.Log(" teste7.");
                    break;
                case 8:
                    Debug.Log(" teste8.");
                    break;
                case 9:
                    Debug.Log(" teste9.");
                    break;
                case 10:
                    Debug.Log(" teste10.");
                    break;

                default:
                    Debug.Log("esse ID não existe");
                    break;
            }
        }
    }

    void Update()
    {
        DisplayHandInUI();
    }

    public void DisplayHandInUI()
    {
        cards = player.GetComponent<HandCards>().getHand();
        display1.GetComponent<Image>().sprite = cards[0].getArtwork();
        display2.GetComponent<Image>().sprite = cards[1].getArtwork();
        display3.GetComponent<Image>().sprite = cards[2].getArtwork();
        display4.GetComponent<Image>().sprite = cards[3].getArtwork();
    }

}
