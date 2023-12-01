using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private SaveData saveData;

    void Awake()
    {
        // Singleton pattern to ensure only one GameManager exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            LoadGame();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LevelCompleted(int levelIndex)
    {
        saveData.levelsCompleted[levelIndex] = true;
        SaveSystem.SaveProgress(saveData);
    }

    public bool IsLevelCompleted(int levelIndex)
    {
        return saveData.levelsCompleted[levelIndex];
    }

    private void LoadGame()
    {
        saveData = SaveSystem.LoadProgress() ?? new SaveData(3); 
    }
   
}
