using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoremanager : MonoBehaviour
{
    public GameObject winui;
   
    public static scoremanager instance;
  
    public Text Scoretext;
    int score = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Scoretext.text = score.ToString() + " TOTAL POINTS";
        
            }
    public void AddPoint()
    {
        score += 10;
        Scoretext.text = score.ToString() + " TOTAL POINTS";
        if (score == 100)
        {
            Time.timeScale = 0;
            winui.SetActive(true);
        }
        else
        {
            winui.SetActive(false);
        }
    }
}
