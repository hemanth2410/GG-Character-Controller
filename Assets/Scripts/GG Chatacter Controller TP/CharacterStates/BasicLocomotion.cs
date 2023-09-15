using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicLocomotion : CharacterSystem
{
    ThirdPersonControllerBrain characterBrain;
    public override void InitializeSystem(ThirdPersonControllerBrain brain)
    {
        characterBrain = brain;
    }

    public override void OnSystemEnter()
    {
        // For not there is nothing here for now.
    }

    public override void OnSystemExit()
    {
        // Ideal place to call should there be a state change.
    }

    public override void OnSystemUpdate()
    {
        // This will be called once per frame
    }
}
