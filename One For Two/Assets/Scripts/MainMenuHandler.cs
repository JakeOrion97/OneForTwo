using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuHandler : MonoBehaviour
{
   

    public void PlayGame(){
       SceneManager.LoadScene("Level2"); 
        
    }

    public void QuitGame(){
        //does not work in editor 
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
