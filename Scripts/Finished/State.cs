using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    public virtual void OnStateEnter(Actor actor)
    {

    }

    public virtual void OnStateExit(Actor actor)
    {

    }

    public virtual void StateUpdate(Actor actor)
    {

    }
}
