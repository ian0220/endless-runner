using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public float ScoreAmount;
    public float PointIncreasedPerSecond;
    
    void Start()
    {
        ScoreAmount = 0f;
        PointIncreasedPerSecond = 1f;
    }

    void Update()
    {
        ScoreText.text = "Score: " + (int)ScoreAmount;
       ScoreAmount += PointIncreasedPerSecond * Time.deltaTime;
    }
}
