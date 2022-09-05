using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI timerText;

    public static GameUI instance;

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }

    public void HpTextUpdate(int hp)
    {
        hpText.text = "<color=green><b>+</b></color>"+hp;
    }
    public void TimerTextUpdate(int timer)
    {
        timerText.text = timer.ToString();
    }
}
