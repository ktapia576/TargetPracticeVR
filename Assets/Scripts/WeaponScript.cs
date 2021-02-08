using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WeaponScript : MonoBehaviour
{
    public Transform barrel = null;
    public GameObject projectilePrefab = null;

    private XRGrabInteractable interactable = null;

    // Use Awake for getting components and cache preformance heavy methods
    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()
    {
        // Add event listner once interactable enabled and activated (When player picks up and "activates")
        interactable.activated.AddListener(Fire);
        Debug.Log("Enabled: " + interactable.enabled + " OnEnable()"); // debug whether enabled or not
    }

    private void OnDisable()
    {
        // Remove event listener once interactable is disabled
        interactable.activated.RemoveListener(Fire);
    }

    private void Fire(BaseInteractionEventArgs arg)
    {
        CreateProjectile();
    }

    private void CreateProjectile()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, barrel.position, barrel.rotation);
        Projectile projectile = projectileObject.GetComponent<Projectile>();    // Get the reference to projectile component script from gameObject

        projectile.Launch();
    }
}
