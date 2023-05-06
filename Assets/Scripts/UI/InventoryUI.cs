using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;
    Player player;
    public List<SotsUI> slots = new List<SotsUI>();

    private void Awake()
    {
        player = GetComponent<Player>();
    }
    private void OnInventory(InputValue inputValue)
    {
        ToggleInventory();
    }

    public void ToggleInventory()
    {
        if (!inventoryPanel.activeSelf)
        {
            inventoryPanel.SetActive(true);
            Refresh();
        }
        else
        {
            inventoryPanel.SetActive(false);
        }
    }

    void Refresh()
    {
        if(slots.Count == player.inventory.slots.Count)
        {
            for (int i = 0; i < slots.Count; i++)
            {
                if(player.inventory.slots[i].type != CollectableType.NONE)
                    slots[i].SetItem(player.inventory.slots[i]);
                else
                    slots[i].SetEmpty();
            }
        }
    }
}
