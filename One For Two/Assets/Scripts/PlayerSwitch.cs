using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public PlayerController playerController; 
    public PlayerController player2Controller; 
    
 
    void Start()
    {
        playerController.enabled = true; 
        player2Controller.enabled = false; 
    }

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            SwitchToPlayer(); 

        }

        
    }

    public void SwitchToPlayer(){
        if (playerController.enabled == true){
            playerController.enabled = false ;
            player2Controller.enabled = true ; 
        }
        else{
            playerController.enabled = true ;
            player2Controller.enabled = false ; 
        }
    }
}
