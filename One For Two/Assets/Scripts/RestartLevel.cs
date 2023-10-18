using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public string currentSceneName;
    
    // Start is called before the first frame update
    public void PlayGame(){
       SceneManager.LoadScene(currentSceneName); 
        
    }

    public void GoHome(){
        //does not work in editor 
        SceneManager.LoadScene("MainMenu"); 
    }
    
    public void QuitGame(){
        //does not work in editor 
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
