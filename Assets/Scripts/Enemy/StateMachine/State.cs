using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    [SerializeField] private List<Transition> _transitons;

    protected Player Target { get; set; }

    public void Enter(Player target)
    {
        if(enabled == false)
        {
            Target = target;
            enabled = true;

            foreach(var transition in _transitons)
            {
                transition.enabled = true;
                transition.Init(Target);
            }
        }
    }

    public void Exit()
    {
        if(enabled == true)
        {
            foreach (var transition in _transitons)
                transition.enabled = false;

            enabled = false;
        }
    }

    public State GetNextState()
    {
        foreach (var transition in _transitons)
        {
            if (transition.NeedTransit)
                return transition.TargetState;
        }

        return null;
    }
}
