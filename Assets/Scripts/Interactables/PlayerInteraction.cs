using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] ShopKeeperInteraction shopKeeper;
    PlayerMovement playerMovement;
    public bool canInteract = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        shopKeeper = collision.GetComponent<ShopKeeperInteraction>();

        if (shopKeeper != null)
        {
            shopKeeper.TogglePrompt();
            canInteract = true;
        }
        else
            canInteract = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (canInteract == true)
        {
            shopKeeper.TogglePrompt();
            canInteract = false;
        }
    }

    private void OnInteract(InputValue inputValue)
    {
        if (canInteract)
        {
            shopKeeper.ToggleDialogue();
        }
    }
}
