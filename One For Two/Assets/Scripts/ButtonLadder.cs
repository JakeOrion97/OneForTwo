using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ButtonLadder : MonoBehaviour
{
     [SerializeField] public Tilemap wallTilemap; // Reference to the Tilemap containing the wall.

    
   
    void Start()
    {
         wallTilemap.gameObject.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Luna") || other.CompareTag("Dad"))
        {
            // Inactivate the wall Tilemap when Luna or Dad enters the button's collider.
            wallTilemap.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Luna") || other.CompareTag("Dad"))
        {
            // Activate the wall Tilemap when Luna or Dad exits the button's collider.
            wallTilemap.gameObject.SetActive(false);
        }
    }

}
