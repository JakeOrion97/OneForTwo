using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindow : MonoBehaviour
{
    public GameObject panel; // Reference to the panel GameObject

    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Hide();
        }
    }
    // Call this method to show the panel
    public void Show()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }

    // Call this method to hide the panel
    public void Hide()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }
}


