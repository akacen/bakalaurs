using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScores : MonoBehaviour
{
    public TMP_InputField inputField;
    public HighScoreDisplay[] highScoreDisplayArray;
    List<HighScoreEntry> scores = new List<HighScoreEntry>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateHighScoreDisplay()
    {
        scores.Sort((HighScoreEntry x, HighScoreEntry y) => y.playerScore.CompareTo(x.playerScore));
        Debug.Log(highScoreDisplayArray.Length);
        for (int i = 0; i < highScoreDisplayArray.Length; i++)
        {
            if (i < scores.Count)
            {
                highScoreDisplayArray[i].DisplayHighScore(scores[i].playerName, scores[i].playerScore);
                Debug.Log("Display "+i);
                Debug.Log(scores[i].playerName);

            }
            else
            {
                highScoreDisplayArray[i].HideEntryDisplay();
                Debug.Log("Hide "+i);

            }
        }
    }
    public void AddNewScore()
    {
        scores.Add(new HighScoreEntry {playerName = inputField.text, playerScore = Time.time});
        // Debug.Log(inputField.text);
        // Debug.Log(scores[0].playerName);

        UpdateHighScoreDisplay();
        // scores.Add(new HighScoreEntry {playerName = entryName , playerScore = entryScore});
    }
}
