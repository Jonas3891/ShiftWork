using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool timerIsRunning = false;
    public Text timeText;

    public float timeRemaining;
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                if(!(timeRemaining > 10))
                {
                    timeText.color = Color.red;
                }
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
                Debug.Log(timeRemaining);
            }
        }
        else
        {
            Debug.Log("Time has run OUT");
            timeRemaining = 0;
            timerIsRunning = false;
        }
    }

    void DisplayTime(float timeTodisplay)
    {
        timeTodisplay += 1;

        float minutes = Mathf.FloorToInt(timeTodisplay / 60);
        float seconds = Mathf.FloorToInt(timeTodisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
