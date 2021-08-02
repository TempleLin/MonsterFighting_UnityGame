using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputsBind : MonoBehaviour, MF_ISignInCompleteCheck
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

    private Vector2 movementVector;

    private bool playerMovementHeld = false;

    private void Start()
    {
        sameTypeIdentityCount++;
        _ICompleteCheck_Identity = "PlayerInputControl" + sameTypeIdentityCount.ToString();
        MF_SignInCompleteCheckCentral.getCalledToSignIn(ref _ICompleteCheck_Identity, this, _ICompleteCheck_SignedIn, ref centralKey);
        
        commanderInfo = GetComponent<MF_CommanderInfo>();
        playerMovement = GetComponent<MF_PlayerMovement>();
        commanderBattle = GetComponent<MF_CommanderBattle>();
        
        MF_SignInCompleteCheckCentral._ICompleteCheck_CheckOthers_Run_MarkCallerComplete(_ICompleteCheck_CentralCallBack_Check_Run_Complete);

    }

    private void OnDisable()
    {
        inputActionMap.Disable();
    }
    
    private void playerMovement_Hold(InputAction.CallbackContext ctx)
    {
        Debug.Log("Hold");
        Debug.Log($"Moving {ctx.ReadValue<Vector2>()}.");
        movementVector = ctx.ReadValue<Vector2>();
        playerMovement.move_Controlled(movementVector);
    }

    private void playerPunchCombo_press()
    {
        commanderBattle.punchCombo_Controlled();
    }

    private void playerKickCombo_press()
    {
        commanderBattle.kickCombo_Controlled();
    }


    public void _ICompleteCheck_CentralCallBack_Check_Run_Complete(int centralKey)
    {
        // Wait for LocalManager to complete assigning everything to player.
        while (!MF_SignInCompleteCheckCentral.getOtherByIdentity("LocalManager").ICompleteCheck_Completed) {}

        inputActionMap = commanderInfo.InputActionMap;
        inputActionMap.Enable();
        inputActionMap.actions[0].performed += ctx => playerMovement_Hold(ctx);
        inputActionMap.actions[1].performed += _ => playerPunchCombo_press();
        inputActionMap.actions[2].performed += _ => playerKickCombo_press();
        //TODO Add more input controls performed

        _ICompleteCheck_Completed = true;
    }
}
