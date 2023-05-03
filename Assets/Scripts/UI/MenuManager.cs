using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class MenuManager : MonoBehaviour
{
    public int gameStartScene;
    // [SerializeField]
    // private TextMeshProUGUI currentScoreText;

    // private float gameEndTime;

    void Start()
    {
        // gameEndTime = Time.time;
        // // Debug.Log(gameEndTime.ToString());
        // Timer.Instance.DisplayTime(gameEndTime, currentScoreText);
        // Debug.Log(Time.time);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(gameStartScene);
    }
    public static void QuitGame() 
    {
        Application.Quit();
    }

}
