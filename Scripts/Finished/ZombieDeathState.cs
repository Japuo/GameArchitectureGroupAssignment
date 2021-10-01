using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeathState : State
{
    public override void OnStateEnter(Actor actor)
    {
        // Call death on gamemanager
        actor.gameManager.OnZombieDeath();
    }

    public override void OnStateExit(Actor actor)
    {

    }

    public override void StateUpdate(Actor actor)
    {

    }
}
