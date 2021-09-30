using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] // So its editable in inspector
public class UI
{
    [SerializeField] private Image playerHealthBar;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private List<Sprite> gunSprites;
    
    public void UpdatePlayerHealth(Player p)
    {
        // Update player health image;
    }

    public void UpdateAmmoCount(Gun.GunType gunType)
    {
        // Update ammo count of current weapon
    }

    public void UpdateWeaponSprite(Gun.GunType gunType)
    {
        // Update weapon to sprite to the new switched weapon (switchcase)
    }
}
