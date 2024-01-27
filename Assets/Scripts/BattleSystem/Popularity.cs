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

    // Update is called once per frame
    void Update()
    {
        PopularityBoundaries();

        popularitySlider.value = popularityScore;
    }

    public int getPopularityScore()
    {
        return popularityScore;
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

    
}
