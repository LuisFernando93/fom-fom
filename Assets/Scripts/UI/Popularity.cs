using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popularity : MonoBehaviour
{

    private int popularityScore;
    [SerializeField] private int popularityMin = -100;
    [SerializeField] private int popularityMax = 100;

    [SerializeField] private Slider popularitySlider;

    void Start()
    {
        popularityScore = 0;
    }

    public void AddPlayerPopularity(int score)
    {
        popularityScore += score;
    }

    public void AddEnemyPopularity(int score)
    {
        popularityScore += -score;
    }

    void PopularityBoundaries()
    {
        if (popularityScore < popularityMin)
        {
            popularityScore = popularityMin;
        } else if (popularityScore > popularityMax)
        {
            popularityScore = popularityMax;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            AddPlayerPopularity(20);
        } else if (Input.GetKeyUp(KeyCode.E))
        {
            AddEnemyPopularity(20);
        }

        PopularityBoundaries();

        popularitySlider.value = popularityScore;
    }
}
