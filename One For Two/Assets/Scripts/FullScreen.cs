using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FullScreen : MonoBehaviour
{
    public Toggle fullscreenToggle;

    void Start()
    {
        // Initialize the toggle based on the current fullscreen setting
        fullscreenToggle.isOn = Screen.fullScreen;

        // Add listener for when the toggle state changes
        fullscreenToggle.onValueChanged.AddListener(delegate { ToggleFullscreen(fullscreenToggle.isOn); });
    }

    public void ToggleFullscreen(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
    }
}
