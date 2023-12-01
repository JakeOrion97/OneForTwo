using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vsync : MonoBehaviour
{
     public Toggle vsyncToggle;

    void Start()
    {
        // Initialize the toggle state based on current VSync setting
        vsyncToggle.isOn = QualitySettings.vSyncCount > 0;

        // Add listener for when the toggle state changes
        vsyncToggle.onValueChanged.AddListener(delegate { ToggleVSync(vsyncToggle.isOn); });
    }

    public void ToggleVSync(bool vsyncEnabled)
    {
        QualitySettings.vSyncCount = vsyncEnabled ? 1 : 0;
    }
}
