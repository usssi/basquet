using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private float timeElapsed = 180f;
    private int minutes, seconds, cents;

    private void Update()
    {
        timeElapsed -= Time.deltaTime;
        minutes = (int)(timeElapsed / 60f);
        seconds = (int)(timeElapsed - minutes * 60f);
        cents = (int)((timeElapsed - (int)timeElapsed) * 100f);


        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);


    }
}
