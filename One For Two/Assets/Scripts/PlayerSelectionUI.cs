using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelectionUI : MonoBehaviour
{
    public Image playerSelectionImage;
    public Sprite player1Image;
    public Sprite player2Image;

    private bool isPlayer1Image = true;

    private void Start()
    {
        // Ensure the playerSelectionImage is set initially to Player1 image
        if (playerSelectionImage != null && player1Image != null)
        {
            playerSelectionImage.sprite = player1Image;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            TogglePlayerImage();
        }
    }

    private void TogglePlayerImage()
    {
        if (isPlayer1Image)
        {
            playerSelectionImage.sprite = player2Image;
        }
        else
        {
            playerSelectionImage.sprite = player1Image;
        }

        isPlayer1Image = !isPlayer1Image;
    }
}
