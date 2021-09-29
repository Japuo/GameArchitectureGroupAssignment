using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Actor
{
    public Actor target;

    protected override void Start()
    {
        SetupStateMachine();
    }

    // Assign target to follow
    public void AssignTarget(Actor _target)
    {
        target = _target;
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        // if health <= 0 call GiveLoot()
    }

    protected override void SetupStateMachine()
    {
        base.SetupStateMachine();

        ZombieWalking zw = new ZombieWalking();
        stateMachine.AddState(zw);

        stateMachine.GoToState(zw);
    }

    private void GiveLoot()
    {
        // Generate Gun class and put a random enum GunType in constructor argument (GunType)
        // Call gameManager.GiveLoot(Gun) put generated gun as argument
    }
}
