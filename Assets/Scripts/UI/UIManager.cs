using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class UIManager : MonoBehaviour
{
    //UI Manager for Sample scene UI
    [SerializeField]
    private TextMeshProUGUI objFoundCount;
    private int objCount;

    public GameObject panel;
    private LevelManager lvlManager;

    void Awake()
    {
        lvlManager = panel.GetComponent<LevelManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        objCount = 0;
        objFoundCount.text = objCount + "/9";
    }

    // Update is called once per frame
    void Update()
    {
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
}
