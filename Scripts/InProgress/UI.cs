using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI
{
    public Image playerHealthBar;
    public SpriteRenderer spriteRenderer;
    public List<Sprite> gunSprites;

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
        // Update weapon to sprite to the new switched weapon
    }
}
