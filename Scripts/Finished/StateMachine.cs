using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    private State currentState;
    private List<State> allStates;
    
    public void GoToState(State nextState)
    {
        // Run OnStateExit from old state
        // Go to New State
        // Run OnStateEnter from next state
    }

    public void AddState(State stateToAdd)
    {
        // Add new state to allStates list
    }

    public bool IsInState(State stateCheck)
    {
        // If "stateCheck" is the same as currentState return true, else false
        return true;
    }

    public State CurrentState
    {
        get { return currentState; }
    }
}
