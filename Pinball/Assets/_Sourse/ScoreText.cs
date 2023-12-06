using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public TextMeshProUGUI TextBalls;
    public int score;
    public int Balls = 5;
    void Start()
    {
        Text.text = score.ToString() + " POINTS";
        TextBalls.text = Balls.ToString() + " Lives";
    }

    public void TakePoints()
    {
        Balls -= 1;
        TextBalls.text = Balls.ToString() + " Lives";
    }

    public void AddPoint()
    {
        score += 1;
        Text.text = score.ToString() + " POINTS";
    }
    public void AddPointBonus()
    {
        Text.text = score.ToString() + " POINTS";
    }
}
