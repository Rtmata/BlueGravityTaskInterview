using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyManager : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] PlayerInteraction playerInteraction;
    [SerializeField] InventoryUI inventoryUI;

    [SerializeField] int itemPrice;

    public void RemoveItem(int slotID)
    {
        if (playerInteraction.canInteract == true)
        {
            player.inventory.Remove(slotID);
            inventoryUI.Refresh();
            SellItem();
        }
    }

    void SellItem()
    {
        player.berryCount += itemPrice;
        player.UpdateBerryCount();
    }
}
