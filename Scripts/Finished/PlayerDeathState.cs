using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathState : State
{
    public override void OnStateEnter(Actor actor)
    {
        actor.gameManager.GameOver();
    }

    public override void OnStateExit(Actor actor)
    {

    }

    public override void StateUpdate(Actor actor)
    {

    }
}
