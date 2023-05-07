using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public Inventory inventory;
    public int berryCount;

    public TextMeshProUGUI berryText;

    public Sprite[] sprites;
    [SerializeField] SpriteRenderer spriteRenderer;

    private void Awake()
    {
        inventory = new Inventory(27);
        berryText.text = berryCount.ToString();
    }

    public void ChangeSprite(int index)
    {
        spriteRenderer.sprite = sprites[index];
    }

    public void UpdateBerryCount()
    {
        berryText.text = berryCount.ToString();
    }
}
