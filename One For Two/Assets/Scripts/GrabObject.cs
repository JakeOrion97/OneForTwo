using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GrabObject : MonoBehaviour
{
    public string lunaTag = "Luna";  // Tag for the player to pick up
    public float pickupDistance = 10.0f;  // Distance within which you can pick up Luna
    public float lunaOffsetY = 1.0f;  // Adjust this value to set Luna's position above the carrying player

    private GameObject luna;
    private bool isHoldingLuna = false;
    private Transform lunaOriginalParent;

    private void Start()
    {
        luna = GameObject.FindGameObjectWithTag(lunaTag);
        if (luna == null)
        {
            Debug.LogError("Luna not found. Make sure Luna has the appropriate tag.");
            enabled = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !isHoldingLuna)
        {
            // Check if Luna is within pickup distance
            float distance = Vector2.Distance(transform.position, luna.transform.position);
            if (distance <= pickupDistance)
            {
                // Pick up Luna
                isHoldingLuna = true;
                lunaOriginalParent = luna.transform.parent;
                luna.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                luna.transform.SetParent(transform);
                Vector3 offset = new Vector3(0, lunaOffsetY, 0);
                luna.transform.localPosition = offset;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Q) && isHoldingLuna)
        {
            // Release Luna
            isHoldingLuna = false;
            luna.transform.SetParent(lunaOriginalParent);
            luna.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }

    
  
}
