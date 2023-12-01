using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timeRemaining = 0;
    public bool timeIsRunning = true;
    public Text timeText;

    void Start()
    {
        timeIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeIsRunning)
        {
            if(timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            }
        }


        void DisplayTime (float timeToDisplay)
        {
            timeToDisplay += 1;
            float minutes2 = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds2 = Mathf.FloorToInt(timeToDisplay % 60);
            timeText.text = string.Format("{0:00} : {1:00}",minutes2 , seconds2);
        }
    }
}

