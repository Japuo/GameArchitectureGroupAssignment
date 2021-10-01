using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotionState : State
{
    public override void OnStateEnter(Actor actor)
    {

    }

    public override void OnStateExit(Actor actor)
    {

    }

    public override void StateUpdate(Actor actor)
    {
        Movement(actor);
    }

    void Movement(Actor actor)
    {
        // Do player movement
    }

    void ShootGun(Actor actor)
    {
        // Shoot players currentGun
        // UpdateUI of gamemanager
    }

    void SwapGun(Actor actor)
    {
        // Swap gun with scroll
        // UpdateUI of gamemanager
        // Update attackDamage of actor to gun.damage
    }

    void MouseLook(Actor actor)
    {
        // Make player rotate to mouse
    }
}