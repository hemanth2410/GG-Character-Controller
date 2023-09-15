using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterSystem : MonoBehaviour
{
    /// <summary>
    /// This method should be called from the character controller brain after validating all the requirements
    /// </summary>
    public abstract void InitializeSystem(ThirdPersonControllerBrain brain);
    /// <summary>
    /// This method should be called from the character controller brain when a change of System is detected
    /// </summary>
    public abstract void OnSystemEnter();
    /// <summary>
    /// This method should be called when in every update cycle for performing animation or logic operations
    /// </summary>
    public abstract void OnSystemUpdate();
    /// <summary>
    /// This method should be called from the same class or from character controller brain to perform clean up
    /// </summary>
    public abstract void OnSystemExit();
}
