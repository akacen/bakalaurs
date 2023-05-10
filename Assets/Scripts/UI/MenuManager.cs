using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class MenuManager : MonoBehaviour
{
    //Game manager for start and end scenes
    public int gameStartScene;

    public void StartGame()
    {
        SceneManager.LoadScene(gameStartScene);
    //    Cursor.visible = false;
    }
    public static void QuitGame() 
    {
        Cursor.visible = true;
    //    Application.Quit();
    }

}
