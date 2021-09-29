using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : IGun
{
    protected int maxAmmo;
    protected float accuracy;
    protected int ammo;
    public int damage;
    public enum GunType { pistol, shotgun, assaultRifle }
    public GunType gunType;

    public Gun(GunType typeGun)
    {
        // Switch State which sets the right values for the type weapon
    }

    public void Shoot()
    {
        // Check if there is enough ammo for this gun to shoot
        // Shoot and calculate accuracy and remove ammo
        // ammo--
    }
}
