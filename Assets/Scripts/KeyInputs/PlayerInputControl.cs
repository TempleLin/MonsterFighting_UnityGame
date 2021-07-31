using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputControl : MonoBehaviour, MF_ISignInCompleteCheck
{
    private static int sameTypeIdentityCount = 0;
    private string _ICompleteCheck_Identity;
    public string ICompleteCheck_Identity => _ICompleteCheck_Identity;
    private bool _ICompleteCheck_Completed = false;
    public bool ICompleteCheck_Completed => _ICompleteCheck_Completed;
    private ValueWrapper<bool> _ICompleteCheck_SignedIn = new ValueWrapper<bool>(false);
    public ValueWrapper<bool> ICompleteCheck_SignedIn => _ICompleteCheck_SignedIn;
    private int centralKey;
    
    [SerializeField] private InputActionMap inputActionMap;
    private MF_CommanderInfo commanderInfo;
    private MF_PlayerMovement playerMovement;
    private MF_CommanderBattle commanderBattle;

    private bool heldKeepMoving = false;
    private Vector2 movementVector;

    private void Start()
    {
        sameTypeIdentityCount++;
        _ICompleteCheck_Identity = "PlayerInputControl" + sameTypeIdentityCount.ToString();
        MF_SignInCompleteCheckCentral.getCalledToSignIn(ref _ICompleteCheck_Identity, this, _ICompleteCheck_SignedIn, ref centralKey);
        
        inputActionMap = commanderInfo.InputActionMap;
        commanderInfo = GetComponent<MF_CommanderInfo>();
        playerMovement = GetComponent<MF_PlayerMovement>();
        commanderBattle = GetComponent<MF_CommanderBattle>();
        
        MF_SignInCompleteCheckCentral._ICompleteCheck_CheckOthers_Run_MarkCallerComplete(_ICompleteCheck_CentralCallBack_Check_Run_Complete);

    }

    private void OnDisable()
    {
        inputActionMap.Disable();
    }

    void Update()
    {
        if (heldKeepMoving)
            playerMovement.move_act(movementVector);
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


    public void _ICompleteCheck_CentralCallBack_Check_Run_Complete(int centralKey)
    {
        // Wait for LocalManager to complete assigning everything to player.
        while (!MF_SignInCompleteCheckCentral.getOtherByIdentity("LocalManager").ICompleteCheck_Completed) {}

        inputActionMap.Enable();
        inputActionMap.actions[0].performed += ctx => playerMovement_act(ctx);
        //TODO Add more input controls performed

        _ICompleteCheck_Completed = true;
    }
}
