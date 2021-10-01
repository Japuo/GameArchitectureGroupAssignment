using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieWalkingState : State
{
    private bool attackCooldown;

    public override void OnStateEnter(Actor actor)
    {

    }

    public override void OnStateExit(Actor actor)
    {

    }

    public override void StateUpdate(Actor actor)
    {
        // If zombie is close enough damage player and wait a second before being able to do again
        if (Vector3.Distance(actor.actorTransform.position, actor.gameManager.player.actorTransform.position) < 1)
        {
            if (attackCooldown == false)
            {
                attackCooldown = true;
                DealDamage(actor);
                actor.Invoke("ResetAttackCooldown", 1);
            }
        }
    }

    //Deal damage to player
    void DealDamage(Actor actor)
    {
        actor.gameManager.player.TakeDamage(actor.attackDamage);
    }

    void ResetAttackCooldown()
    {
        attackCooldown = false;
    }
}
