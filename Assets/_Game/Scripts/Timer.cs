using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(TimerIncrease());
    }

    private IEnumerator TimerIncrease()
    {
        while (true)
        {
            GameManager.instance.TimerIncrease();
            yield return new WaitForSeconds(1f);
        }
    }
}
