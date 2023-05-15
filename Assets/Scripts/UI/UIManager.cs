using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    //UI Manager for Sample scene UI
    [SerializeField]
    private TextMeshProUGUI objFoundCount;
    private int objCount;

    public GameObject panel;
    private LevelManager lvlManager;
    public int gameStartScene;
    void Awake()
    {
        lvlManager = panel.GetComponent<LevelManager>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        objCount = 0;
        objFoundCount.text = objCount + "/9";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(gameStartScene);
        }

        objFoundCount.text = objCount + "/9";
    }
    public void UpdateFoundCount()
    {
        if (objCount < 8)
        {
            objCount ++;
        } else {
            objCount = 9;
            lvlManager.RevealInfo();
        }
    }

        void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
