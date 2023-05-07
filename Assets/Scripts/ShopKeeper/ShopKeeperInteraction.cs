using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeperInteraction : MonoBehaviour
{
    public GameObject ShopKeeperDialogue;
    public PlayerMovement playerMovement;
    public GameObject prompt;

    public void TogglePrompt()
    {
        if (!prompt.activeSelf)
        {
            prompt.SetActive(true);

        }
        else
        {
            prompt.SetActive(false);
        }
    }

    public void ToggleDialogue()
    {
        if (!ShopKeeperDialogue.activeSelf)
        {
            playerMovement.canMove = false;
            ShopKeeperDialogue.SetActive(true);
        }
        else
        {
            playerMovement.canMove = true;
            ShopKeeperDialogue.SetActive(false);
        }
    }
}
