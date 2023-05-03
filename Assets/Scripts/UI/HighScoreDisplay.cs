using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI scoreText;
    public HighScoreDisplay[] highScoreDisplayArray;
    List<HighScoreEntry> scores = new List<HighScoreEntry>();

    // Start is called before the first frame update
    void Start()
    {
        AddNewScore("John", 4500);
        AddNewScore("Max", 5520);
        AddNewScore("Dave", 380);
        AddNewScore("Steve", 6654);
        AddNewScore("Mike", 11021);
        AddNewScore("Teddy", 3252);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateHighScoreDisplay()
    {
        scores.Sort((HighScoreEntry x, HighScoreEntry y) => y.playerScore.CompareTo(x.playerScore));
        for (int i = 0; i < highScoreDisplayArray.Length; i++)
        {
            if (i < scores.Count)
            {
                highScoreDisplayArray[i].DisplayHighScore(scores[i].playerName, scores[i].playerScore);
            }
            else
            {
                highScoreDisplayArray[i].HideEntryDisplay();
            }
        }
    }
    void AddNewScore(string entryName, float entryScore)
    {
        scores.Add(new HighScoreEntry {playerName = entryName , playerScore = entryScore});
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
