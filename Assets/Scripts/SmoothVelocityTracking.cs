using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SmoothVelocityTracking : MonoBehaviour
{
    private Rigidbody rigidBody = null; // Create var for rigidbody of interactable

    private void Awake()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>(); // Get rigidBody of game object

        rigidBody.maxAngularVelocity = 20f; // The default is 7 which is too low for fast movements (smoothes object when moving)
    }
}
