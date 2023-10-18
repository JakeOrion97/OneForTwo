using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabKey : MonoBehaviour
{
    public string keyTag = "Key";  // Tag for the player to pick up
    public float pickupDistance = 1.0f;  // Distance within which you can pick up Key
    public float keyOffsetX = 0.5f;  // Adjust this value to set the Key's position above the carrying player

    private GameObject key;
    private bool isHoldingkey = false;
    private Transform keyOriginalParent;
    public PlayerController player2Controller;

    private void Start()
    {
        key = GameObject.FindGameObjectWithTag(keyTag);
        if (key == null)
        {
            Debug.LogError("Key not found. Make sure Key has the appropriate tag.");
            enabled = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isHoldingkey && player2Controller || (!player2Controller && isHoldingkey))
        {
            // Check if key is within pickup distance
            float distance = Vector2.Distance(transform.position, key.transform.position);
            if (distance <= pickupDistance)
            {
                // Pick up Key
                isHoldingkey = true;
                keyOriginalParent = key.transform.parent;
                key.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                key.transform.SetParent(transform);
                Vector3 offset = new Vector3(keyOffsetX,0 , 0);
                key.transform.localPosition = offset;
            }
        }
        else if (Input.GetKeyDown(KeyCode.E) && isHoldingkey)
        {
            // Release Key
            isHoldingkey = false;
            key.transform.SetParent(keyOriginalParent);
            key.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
