using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
     [SerializeField] public float countdownTime = 60f;

    private float currentTime;
    private bool isPaused = false;
    private bool isFlashing = false;
    private float flashTimer = 0f;
    private float flashDuration = 0.5f; // Duration of each color flash

    public void GoHome(){
       SceneManager.LoadScene("Game Over"); 
        
    }

    void Start()
    {
        currentTime = countdownTime;
    }

    void Update()
    {
        // Handle pausing and unpausing
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }

        // Update timer if the game is not paused
        if (!isPaused && currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerDisplay(currentTime);

            // Check if timer is below 30 seconds
            if (currentTime <= 30f && !isFlashing)
            {
                isFlashing = true;
                timerText.color = Color.red;
            }

          
            if (isFlashing)
            {
                FlashTimerColor();
            }
        }
        else if (currentTime <= 0)
        {
            currentTime = 0;
            
            GoHome(); 
        }
    }

    private void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
    }

    void UpdateTimerDisplay(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void FlashTimerColor()
    {
        flashTimer += Time.deltaTime;

        if (flashTimer >= flashDuration)
        {
            timerText.color = timerText.color == Color.red ? Color.white : Color.red;
            flashTimer = 0f;
        }
    }
}
