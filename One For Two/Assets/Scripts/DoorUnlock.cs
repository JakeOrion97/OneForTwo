using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorUnlock : MonoBehaviour
{
    public GameObject door;
    public GameObject balloonPrefab;
    public string nextSceneName;

    private bool isDoorUnlocked = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Key") && !isDoorUnlocked)
        {
            // Spawn the balloon above the door
            Vector3 balloonPosition = new Vector3(door.transform.position.x, door.transform.position.y + 1.5f, door.transform.position.z);
            Instantiate(balloonPrefab, balloonPosition, Quaternion.identity);

            // Wait for 3 seconds and then load the next scene
            StartCoroutine(LoadNextScene());
            isDoorUnlocked = true;
        }
    }

    private IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(nextSceneName);
    }
}
