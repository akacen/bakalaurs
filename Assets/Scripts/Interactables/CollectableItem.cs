using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableItem : Interactable
{
    [SerializeField]
    private TextMeshProUGUI itemText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        base.Interact();
        Destroy(gameObject);
        UIManager.UpdateFoundCount();
        itemText.color = Color.grey;
    }
}
