using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : ObjectsInScene
{
    protected StateMachine stateMachine;

    public GameManager gameManager;
    public Transform actorTransform;
    public int attackDamage = 10;

    private int health = 100;

    protected virtual void Start()
    {
        // Reference actor transform
        actorTransform = gameObject.transform;
    }

    public void ReferenceGm(GameManager gm)
    {
        // Reference the gameManager
        gameManager = gm;
    }

    public virtual void TakeDamage(int damage)
    {
        // Health -= damage;
        // If health <= 0 go to dead state
    }

    // Call the update loop of the currentState
    protected virtual void Update()
    {
        stateMachine.CurrentState.StateUpdate(this);
    }

    // Create and add new state objects to the stateMachine
    protected virtual void SetupStateMachine()
    {
        // Add State Dead to statemachine
    }
}