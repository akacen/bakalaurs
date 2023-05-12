using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableItem : Interactable
{
    [SerializeField]
    private TextMeshProUGUI itemText;
    public GameObject panel;
    public AudioClip audioClip;
    private UIManager uiManager;
    // Awake is called when the script instance is being loaded.
    void Awake()
    {
        uiManager = panel.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        base.Interact();
        AudioSource.PlayClipAtPoint(audioClip, transform.position);
        Destroy(gameObject);
        uiManager.UpdateFoundCount();
        itemText.color = Color.grey;
    }
}
