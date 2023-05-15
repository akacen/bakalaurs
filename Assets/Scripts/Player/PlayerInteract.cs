using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField]
    private float distance = 25f;
    [SerializeField]
    private LayerMask mask;
    private InputManager inputManager;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo; //variable to store collision information
        if (Physics.Raycast(ray, out hitInfo, distance, mask)) //raycast function returns boolean, true if it hits something. Raycasting to the center of the screen
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null) //checking if gameobject has interactable component
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();
                }
            }
        } 
    }
}

