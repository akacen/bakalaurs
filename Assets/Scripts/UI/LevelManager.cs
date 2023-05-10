using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject lvlFinishedPanel;
    [SerializeField]
    private GameObject keypad;
    [SerializeField]
    private GameObject gameManager;
    private Timer timer;
    public int gameEndScene;

    void Awake()
    {
        timer = gameManager.GetComponent<Timer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void RevealInfo()
    {
        lvlFinishedPanel.SetActive(true);
        keypad.SetActive(true);
    }

    public void EndGame()
    {
        PlayerPrefs.SetString("CurrentScoreText", timer.timerText.text);
        PlayerPrefs.SetFloat("CurrentScoreFloat", timer.timeNow);
        SceneManager.LoadScene(gameEndScene);
        Cursor.visible = true;
    }
}
