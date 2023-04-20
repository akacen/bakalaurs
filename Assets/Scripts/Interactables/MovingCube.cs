using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : Interactable
{
    Animator animator;
    private string startPromt;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        startPromt = promtMessage;
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Default"))
        {
            promtMessage = startPromt;
        }
        else {
            promtMessage = "Animating..";
        }
    }

    protected override void Interact()
    {
        base.Interact();
        animator.Play("Spin");
    }
}
