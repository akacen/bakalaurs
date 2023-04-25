using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI objFoundCount;

    // [SerializeField]
    // private TextMeshProUGUI objFoundCount;
    private int objCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        objFoundCount.text = objCount + "/10";
    }

    // Update is called once per frame
    void Update()
    {
        objFoundCount.text = objCount + "/10";
    }
    public void updateFoundCount()
    {
        objCount ++;
    }
}
