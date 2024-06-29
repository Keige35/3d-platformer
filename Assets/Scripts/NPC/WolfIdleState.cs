using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;

public class WolfIdleState : State
{
    private readonly NpcAnimationController npcAnimationController;

    public WolfIdleState(NpcAnimationController npcAnimationController)
    {
        this.npcAnimationController = npcAnimationController;
    }

    public override void OnStateEntered()
    {
        npcAnimationController.SetBool(NpcAnimationType.Idle, true);
    }

    public override void OnStateExited()
    {
        npcAnimationController.SetBool(NpcAnimationType.Idle, false);
    }
}
