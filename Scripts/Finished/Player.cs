using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Actor
{
    public Gun currentGun;

    [SerializeField] private GameObject bullet; // SerializeField so we can add the prefab in inspector
    private List<Gun> availableGuns = new List<Gun>();

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        gameManager.UpdateUI(this);

        // Update UI in gamemanager
    }

    protected override void SetupStateMachine()
    {
        base.SetupStateMachine();

        PlayerLocomotionState lm = new PlayerLocomotionState();
        stateMachine.AddState(lm);

        stateMachine.GoToState(lm);
    }

    protected override void ActorUpdate()
    {
        base.ActorUpdate();
    }

    public void PickUpGun(Gun.GunType typeGun)
    {
        // Add gun to the list
    }
}
