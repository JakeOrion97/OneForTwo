using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;


public class Death : MonoBehaviour
{
    public GameObject spike;
    public string currentSceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Dad") || other.CompareTag("Luna"))
        {
           SceneManager.LoadScene(currentSceneName); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.collider is TilemapCollider2D)
        {
            SceneManager.LoadScene(currentSceneName); 
        }
    }

    

}
