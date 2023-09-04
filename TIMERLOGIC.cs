using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TIMERLOGIC : MonoBehaviour
{
    public GameObject GamewinUi;
    int countdownstartvalue = 60;
    public Text timeui;
    void Start()
    {
        countDownTimer();
    }
    void countDownTimer()
    {
        if (countdownstartvalue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countdownstartvalue);
            timeui.text = spanTime.Minutes + ":" + spanTime.Seconds;
            countdownstartvalue--;
            Invoke("countDownTimer", 1.0f);
                  GamewinUi.SetActive(false);
        }
        else
        {
           GamewinUi.SetActive(true);
        }
    }
}
