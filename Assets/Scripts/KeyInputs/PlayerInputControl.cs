using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputControl : MonoBehaviour
{
    private MF_CommanderInfo commanderInfo;
    [SerializeField] private InputActionMap inputActionMap;

    private MF_PlayerMovement playerMovement;

    private bool heldKeepMoving = false;
    private Vector2 movementVector;
    
    void Start()
    {
        commanderInfo = GetComponent<MF_CommanderInfo>();
        inputActionMap = commanderInfo.InputActionMap;

        playerMovement = GetComponent<MF_PlayerMovement>();

        inputActionMap.actions[0].performed += ctx => playerMovement_act(ctx);
    }

    // private void OnEnable()
    // {
    //     inputActionMap.Enable();
    // }

    private void OnDisable()
    {
        inputActionMap.Disable();
    }

    void Update()
    {
        if (inputActionMap != null && !inputActionMap.enabled)
            inputActionMap.Enable();
        Debug.Log(inputActionMap.FindAction("Movement"));
        
        if (heldKeepMoving)
            playerMovement.move_pas(movementVector);
    }

    private void playerMovement_act(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            heldKeepMoving = true;
            movementVector = ctx.ReadValue<Vector2>();
        }
        else if (ctx.canceled)
        {
            heldKeepMoving = false;
        }
    }
}
