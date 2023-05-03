using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI objFoundCount;
    private static int objCount;
    public static int gameEndScene = 2;
    // Start is called before the first frame update
    void Start()
    {
        objCount = 0;
        objFoundCount.text = objCount + "/10";
    }

    // Update is called once per frame
    void Update()
    {
        objFoundCount.text = objCount + "/10";
    }
    public static void UpdateFoundCount()
    {
        if (objCount < 2)
        {
            objCount ++;
        } else {
            objCount = 10;
            EndGame();
        }
    }

    public static void EndGame()
    {
        SceneManager.LoadScene(gameEndScene);
    }
}
