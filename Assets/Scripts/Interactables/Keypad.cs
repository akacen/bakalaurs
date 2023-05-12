using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool isDoorOpen;
    public AudioClip audioClip;
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
        AudioSource.PlayClipAtPoint(audioClip, transform.position);
        isDoorOpen = !isDoorOpen;
        door.GetComponent<Animator>().SetBool("isOpen", isDoorOpen);
    }
}
