using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MF_CommanderPlayerControl : MF_PCommanderSelfControl, MF_ISignInCompleteCheck
{
    private static int sameTypeIdentityCount = 0;
    private string _ICompleteCheck_Identity = "PlayerCommanderControl" + sameTypeIdentityCount++;
    private bool _ICompleteCheck_Completed = false;
    private ValueWrapper<bool> _ICompleteCheck_SignedIn = new ValueWrapper<bool>(false);
    private int centralKey;

    [SerializeField] private InputActionMap inputActionMap;
    //private MF_CommanderInfo commanderInfo;
    //private MF_PlayerMovement playerMovement;
    //private MF_CommanderBattle commanderBattle;

    [SerializeField] private MF_CommanderScriptComponentsLink otherScriptComponents;
    
    public string ICompleteCheck_Identity => _ICompleteCheck_Identity;
    public bool ICompleteCheck_Completed => _ICompleteCheck_Completed;
    public ValueWrapper<bool> ICompleteCheck_SignedIn => _ICompleteCheck_SignedIn;

    private void Start()
    {
        MF_SignInCompleteCheckCentral.getCalledToSignIn(ref _ICompleteCheck_Identity, this, _ICompleteCheck_SignedIn, ref centralKey);
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
        otherScriptComponents.Movement.move_Controlled(movementVector);
    }

    private void playerPunchCombo_press()
    {
        otherScriptComponents.CommanderBattle.punchCombo_Controlled();
    }

    private void playerKickCombo_press()
    {
        otherScriptComponents.CommanderBattle.kickCombo_Controlled();
    }

    public void _ICompleteCheck_CentralCallBack_Check_Run_Complete(int centralKey)
    {
        // Wait for LocalManager to complete assigning everything to player.
        MF_SignInCompleteCheckCentral._ICompleteCheck_WaitForComplete(GetComponent<MF_CommanderManager>()
            .ICompleteCheck_Identity);
        
        //commanderInfo = GetComponent<MF_CommanderInfo>();
        //playerMovement = GetComponent<MF_PlayerMovement>();
        //commanderBattle = GetComponent<MF_CommanderBattle>();
        otherScriptComponents = GetComponent<MF_CommanderScriptComponentsLink>();
        Debug.LogWarning(otherScriptComponents._movement);
        Debug.LogWarning(otherScriptComponents._commanderBattle);
        Debug.LogWarning(otherScriptComponents._commanderAutoControl);
        Debug.LogWarning(otherScriptComponents._commanderSelfControl);
        Debug.LogWarning(otherScriptComponents._commanderInfo);

        inputActionMap = otherScriptComponents.CommanderInfo.InputActionMap;
        inputActionMap.Enable();
        inputActionMap.actions[0].performed += ctx => playerMovement_Hold(ctx);
        inputActionMap.actions[1].performed += _ => playerPunchCombo_press();
        inputActionMap.actions[2].performed += _ => playerKickCombo_press();
        //TODO Add more input controls performed

        _ICompleteCheck_Completed = true;
    }
}
