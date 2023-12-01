using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalTime : MonoBehaviour
{
    public Text textfinaltime;
    public Timer timer;

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes2 = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds2 = Mathf.FloorToInt(timeToDisplay % 60);
        textfinaltime.text = string.Format("{0:00} : {1:00}", minutes2, seconds2);
    }
    void Start()
    {

        //textfinaltime.text = Timer.timeRemaining.ToString();
        DisplayTime(Timer.timeRemaining);

    }

    
}
