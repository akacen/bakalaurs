using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestLid : Interactable
{
    [SerializeField]
    private GameObject chestLid;
    private bool lidOpen;
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
        lidOpen = !lidOpen;
        chestLid.GetComponent<Animator>().SetBool("IsLidOpen", lidOpen);
    }
}
