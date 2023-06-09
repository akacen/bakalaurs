using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreDisplay : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI scoreText;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void DisplayHighScore(string nameToDisplay, float scoreToDisplay)
    {
        nameText.text = nameToDisplay;
        DisplayTimeText(scoreToDisplay, scoreText);
    }
    public void DisplayTimeText(float timeToDisplay, TextMeshProUGUI textToDisplay )
    {
        float hours = Mathf.FloorToInt(timeToDisplay / 3600);
        float minutes = Mathf.FloorToInt(timeToDisplay % 3600 / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        textToDisplay.text = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
    }

    public void HideEntryDisplay()
    {
        nameText.text = "";
        scoreText.text = "";

    }
}
