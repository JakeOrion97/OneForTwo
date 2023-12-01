using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public string currentSceneName;
    
    
    public void PlayGame(){
       SceneManager.LoadScene(currentSceneName); 
        
    }

    public void GoHome(){
        
        SceneManager.LoadScene("MainMenu"); 
    }
    
    public void QuitGame(){
        
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
