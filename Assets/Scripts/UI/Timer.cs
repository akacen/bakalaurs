using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeNow;
    public bool countDown;
    private float hours, minutes, seconds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if counting down, it will remove time every frame, if counting up - it will add time.
        //allows to make two different game modes - limited time or fastest player.
        timeNow = countDown ? timeNow -= Time.deltaTime : timeNow += Time.deltaTime;
        DisplayTime(timeNow, timerText);
    }

    public void DisplayTime(float timeToDisplay, TextMeshProUGUI textToDisplay)
    {
        hours = Mathf.FloorToInt(timeToDisplay / 3600);
        minutes = Mathf.FloorToInt(timeToDisplay % 3600 / 60);
        seconds = Mathf.FloorToInt(timeToDisplay % 60);

        textToDisplay.text = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
    }
}
