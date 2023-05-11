using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // function to be called from player
    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        //template function to be overridden by subclasses
    }
}
