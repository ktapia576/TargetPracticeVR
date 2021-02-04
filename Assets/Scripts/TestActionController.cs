using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TestActionController : MonoBehaviour
{
    private ActionBasedController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ActionBasedController>();

        bool isPressed = controller.selectAction.action.ReadValue<bool>(); // Can store to use later or in update function

        controller.selectAction.action.performed += Action_performed;   // OR have a function be added to a event list to be called when the event is called
    }

    private void Action_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Debug.Log("Select button is Pressed!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
