using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public Button[] buttonsIds;
    public ClothItemManager[] clothItem;
    public RuntimeAnimatorController[] controllers;

    [SerializeField] Player player;
    [SerializeField] Animator playerAnimator;

    public GameObject[] price;
    public GameObject[] ownedTag;

    private void Start()
    {
        //I tried to do a oop for the isteners but got some issues and for time I just did it manually
        //for (int i = 0; i < buttonsIds.Length; i++)
        //{
        //    buttonsIds[i].onClick.AddListener(() => OnButtonClick(i));
        //}
        buttonsIds[0].onClick.AddListener(() => OnButtonClick(0));
        buttonsIds[1].onClick.AddListener(() => OnButtonClick(1));
        buttonsIds[2].onClick.AddListener(() => OnButtonClick(2));
        buttonsIds[3].onClick.AddListener(() => OnButtonClick(3));
        buttonsIds[4].onClick.AddListener(() => OnButtonClick(4));
        buttonsIds[5].onClick.AddListener(() => OnButtonClick(5));
        buttonsIds[6].onClick.AddListener(() => OnButtonClick(6));
        buttonsIds[7].onClick.AddListener(() => OnButtonClick(7));
        buttonsIds[8].onClick.AddListener(() => OnButtonClick(8));
    }


    public void OnButtonClick(int buttonInt)
    {
        if(clothItem[buttonInt].isUnlocked == false)
            SellItem(buttonInt);
        else
        {
            ChangeClothes(buttonInt);
        }

    }
    
    public void SellItem(int buttonInt)
    {
        if(player.berryCount >= clothItem[buttonInt].itemPrice)
        {
            clothItem[buttonInt].isUnlocked = true;
            player.berryCount -= clothItem[buttonInt].itemPrice;
            player.UpdateBerryCount();
            price[buttonInt].SetActive(false);
            ownedTag[buttonInt].SetActive(true);
        }
    }

    public void ChangeClothes(int buttonInt)
    {
        playerAnimator.runtimeAnimatorController = controllers[buttonInt];
        player.ChangeSprite(buttonInt);
    }

}
