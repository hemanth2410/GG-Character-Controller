using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonControllerBrain : MonoBehaviour
{
    CharacterSystem[] characterSystems;
    bool blockExecution;


    // should read inuts from CHaracterContrillerInputs.cs
    // should only move the character in every fixed update
    // either by relaying information back from current state
    // to this class or call CurrentState.OnStateUpdate() in 
    // FixedUpdate(), But there can be some character states
    // where we need to run it every frame instead of every
    // FixedUpdate(), So relaying information back is the way to GO.
    // Reading input values should be only one reference away from States.

    #region Cache
    float horizontal;
    float vertical;
    float mouseX;
    float mouseY;

    bool isSprinting;
    bool isJumping;
    #endregion

    #region PublicProperties
    public float Horizontal { get { return horizontal; } }
    public float Vertical { get { return vertical; } }
    public float MouseX { get {  return mouseX; } }
    public float MouseY { get {  return mouseY; } }
    public bool IsSprinting { get { return isSprinting; } }
    public bool IsJumping { get { return isJumping; } }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //Check for dependencies
        //Initialize states
        characterSystems = GetComponentsInChildren<CharacterSystem>();
        foreach (CharacterSystem c in characterSystems)
        {
            c.InitializeSystem(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (blockExecution)
            return;
        foreach (CharacterSystem c in characterSystems)
            c.OnSystemUpdate();
    }
    private void LateUpdate()
    {
        if(blockExecution)
            return;
    }
    private void FixedUpdate()
    {
        if (blockExecution)
            return;
    }
}
