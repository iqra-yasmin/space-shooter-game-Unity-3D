using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scorecontroller : MonoBehaviour
{
    public static scorecontroller instance;

    public Text Scoretext;
    public Text TotalScore;
    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        Scoretext.text = score.ToString() + "POINTS";
        TotalScore.text = "HIGHSCORE" + highscore.ToString();
    }
    public void AddPoint()
    {
        score += 5;
       
        Scoretext.text = score.ToString() + "POINTS";
        
         if (highscore < score)
        {
            PlayerPrefs.SetInt("HIGHSCORE", score);
        }
    }
}
