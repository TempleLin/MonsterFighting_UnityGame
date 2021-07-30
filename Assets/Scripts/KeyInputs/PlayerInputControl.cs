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
    
    void Start()
    {
        commanderInfo = GetComponent<MF_CommanderInfo>();
        inputActionMap = commanderInfo.InputActionMap;

        playerMovement = GetComponent<MF_PlayerMovement>();

        inputActionMap.actions[0].performed += ctx => playerMovement_act(ctx.ReadValue<Vector2>());
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
    }

    private void playerMovement_act(Vector2 readValue)
    {
        Debug.Log(readValue);
        playerMovement.move_pas(readValue);
    }
    
}
