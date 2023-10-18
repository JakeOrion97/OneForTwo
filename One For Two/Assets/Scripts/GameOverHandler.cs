using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverHandler : MonoBehaviour
{
    public void GoHome(){
       SceneManager.LoadScene("MainMenu"); 
        
    }

    public void QuitGame(){
        //does not work in editor 
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
