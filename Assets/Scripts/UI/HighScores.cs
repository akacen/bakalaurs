using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScores : MonoBehaviour
{
    public TMP_InputField inputField;
    public HighScoreDisplay[] highScoreDisplayArray;
    List<HighScoreEntry> scores = new List<HighScoreEntry>();

    [SerializeField]
    private TextMeshProUGUI currentScoreText;
    private string currentScoreString;
    private float CurrentScoreFloat;
    // Start is called before the first frame update
    void Start()
    {
        //Get player result from PlayerPrefs and display it.
        currentScoreString = PlayerPrefs.GetString("CurrentScoreText");
        CurrentScoreFloat = PlayerPrefs.GetFloat("CurrentScoreFloat");
        currentScoreText.text = "Your score: " + currentScoreString;
        LoadHighScores();
        UpdateHighScoreDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateHighScoreDisplay()
    {
        scores.Sort((HighScoreEntry x, HighScoreEntry y) => x.playerScore.CompareTo(y.playerScore));
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

    public void AddNewScore()
    {
        scores.Add(new HighScoreEntry {playerName = inputField.text, playerScore = CurrentScoreFloat});
        UpdateHighScoreDisplay();
        SaveHighScores();
    }

    void SaveHighScores()
    {
        XMLManager.instance.SaveScores(scores);
    }

    void LoadHighScores()
    {
        scores = XMLManager.instance.LoadScores();
    }
}
