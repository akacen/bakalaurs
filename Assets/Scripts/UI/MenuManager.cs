using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class MenuManager : MonoBehaviour
{
    //Game manager for start and end scenes
    public int gameStartScene;

    void Start()
    {

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
