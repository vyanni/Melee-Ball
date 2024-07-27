using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class StopWatch : MonoBehaviour
{
    float currentTime;
    public Text currentTimeText;
    public static bool timerActive = false;
    public Text Counter;

    void Start()
    {
        timerActive = true;
        currentTime = 0;
        Counter = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"m\:ss");

        if (PlayerMovement.isDead)
        {
            StopTimer();
            Counter.color = new Color(1f, 1f, 1f, 1f);

        }
    }

    public void StopTimer()
    {
        timerActive = false;
    }
}
