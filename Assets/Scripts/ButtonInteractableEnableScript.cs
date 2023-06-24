using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInteractableEnableScript : MonoBehaviour
{
    // Public Variables
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Call on click
    private void OnMouseDown()
    {
        if (button.IsInteractable())
        {
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
    }
}
