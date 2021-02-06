using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WeaponScript : MonoBehaviour
{
    private XRGrabInteractable interactable = null;

    // Use Awake for getting components and cache preformance heavy methods
    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()
    {
        // Add event listner once interactable is picked up (enabled) and activated
        interactable.activated.AddListener(Fire);
    }

    private void OnDisable()
    {
        // Remove event listener once interactable is disabled
        interactable.activated.RemoveListener(Fire);
    }

    private void Fire(BaseInteractionEventArgs arg)
    {
        Debug.Log("Fire");
        Debug.Log("Enabled: "+interactable.enabled); // debug whether enabled or not
    } 
}
