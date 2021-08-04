using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MF_CommanderAutoControl : MonoBehaviour, MF_ISignInCompleteCheck
{
    private static int sameTypeIdentityCount = 0;
    private string _ICompleteCheck_Identity = "CommanderAutoControl" + sameTypeIdentityCount++;
    private bool _ICompleteCheck_Completed;
    private ValueWrapper<bool> _ICompleteCheck_SignedIn = new ValueWrapper<bool>(false);
    private int centralKey;

    [SerializeField] private MF_CommanderScriptComponentsLink otherScriptComponents;
    
    //[SerializeField] private MF_CommanderInfo commanderInfo;
    //[SerializeField] private MF_PCommanderSelfControl commanderSelfControl;
    //[SerializeField] private MF_PMovement movement;
    
    public string ICompleteCheck_Identity => _ICompleteCheck_Identity;
    public bool ICompleteCheck_Completed => _ICompleteCheck_Completed;
    public ValueWrapper<bool> ICompleteCheck_SignedIn => _ICompleteCheck_SignedIn;

    void Start()
    {
        MF_SignInCompleteCheckCentral.getCalledToSignIn(ref _ICompleteCheck_Identity, this, _ICompleteCheck_SignedIn,
            ref centralKey);
        MF_SignInCompleteCheckCentral._ICompleteCheck_CheckOthers_Run_MarkCallerComplete(
            _ICompleteCheck_CentralCallBack_Check_Run_Complete);
    }

    void Update()
    {
        try
        {
            otherScriptComponents.Movement.move_Controlled(otherScriptComponents.CommanderSelfControl
                .MovementVector);
        }
        catch (NullReferenceException e)
        {
        }
    }

    public void _ICompleteCheck_CentralCallBack_Check_Run_Complete(int centralKey)
    {
        MF_SignInCompleteCheckCentral._ICompleteCheck_WaitForComplete(GetComponent<MF_CommanderScriptComponentsLink>().ICompleteCheck_Identity);

        otherScriptComponents = GetComponent<MF_CommanderScriptComponentsLink>();
        Debug.LogWarning(otherScriptComponents.Movement);
        Debug.LogWarning(otherScriptComponents.CommanderInfo);
        Debug.LogWarning(otherScriptComponents.CommanderBattle);
        Debug.LogWarning(otherScriptComponents.CommanderAutoControl);
        Debug.LogWarning(otherScriptComponents.CommanderSelfControl);

        //commanderInfo = GetComponent<MF_CommanderInfo>();
        //commanderSelfControl = GetComponent<MF_PCommanderSelfControl>();
        //movement = GetComponent<MF_PMovement>();
    }
}
