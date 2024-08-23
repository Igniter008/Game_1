using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Gamemanager : MonoBehaviour
{
    int coinColl = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI TimerText;

    public GameObject winPanel;
    public GameObject losspanel;

    public float timer = 20;

    public void coinAdd()
    {
        coinColl++;
        scoreText.text = "Coin : " + coinColl;
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            TimeSpan timerData = TimeSpan.FromSeconds(timer);
            TimerText.text = "Timer : " + timerData.Seconds;

            if (coinColl == 6)
            {
                winPanel.SetActive(true);
                Time.timeScale = 0f;

            }
        }
        else
        {
            losspanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}