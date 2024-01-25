using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popularity : MonoBehaviour
{
    private int popularityScore;
    [SerializeField] private int popularityMin = -100;
    [SerializeField] private int popularityMax = 100;

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
        PopularityBoundaries();
    }
}
