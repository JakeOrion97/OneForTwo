using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderMovement : MonoBehaviour
{
    private float vertical; 
    private bool isLadder;
    private bool isClimbing; 

    [SerializeField] private float climbingSpeed = 8f; 
    [SerializeField] Rigidbody2D rb; 
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
   
        if (isLadder && Mathf.Abs(vertical) > 0f){
            isClimbing = true; 

           
        }
    }

    private void FixedUpdate(){
        if(isClimbing){
            rb.gravityScale = 0f; 
            rb.velocity = new Vector2(rb.velocity.x, vertical* climbingSpeed);
        }
        else{
            rb.gravityScale = 9f;
        }
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ladder")){
            isLadder = true; 

        }
    }

     private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Ladder")){
            isLadder = false; 
            isClimbing = false; 
        }
    }

}