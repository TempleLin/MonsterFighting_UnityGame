using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MF_CommanderScriptComponentsLink : MonoBehaviour, MF_ISignInCompleteCheck
{
    private static int sameTypeIdentityCount = 0;
    private string _ICompleteCheck_Identity = "CommanderScriptComponentsLink" + sameTypeIdentityCount++;
    private bool _ICompleteCheck_Completed;
    private ValueWrapper<bool> _ICompleteCheck_SignedIn = new ValueWrapper<bool>(false);
    private int centralKey;
    
    [SerializeField] public MF_CommanderInfo _commanderInfo;
    [SerializeField] public MF_CommanderBattle _commanderBattle;
    [SerializeField] public MF_PMovement _movement;
    [SerializeField] public MF_CommanderAutoControl _commanderAutoControl;
    [SerializeField] public MF_PCommanderSelfControl _commanderSelfControl;

    public string ICompleteCheck_Identity => _ICompleteCheck_Identity;
    public bool ICompleteCheck_Completed => _ICompleteCheck_Completed;
    public ValueWrapper<bool> ICompleteCheck_SignedIn => _ICompleteCheck_SignedIn;
    public MF_CommanderInfo CommanderInfo => _commanderInfo;
    public MF_CommanderBattle CommanderBattle => _commanderBattle;
    public MF_PMovement Movement => _movement;
    public MF_CommanderAutoControl CommanderAutoControl => _commanderAutoControl;
    public MF_PCommanderSelfControl CommanderSelfControl => _commanderSelfControl;
    
    void Start()
    {
        Debug.LogWarning("ScriptLink started.");
        MF_SignInCompleteCheckCentral.getCalledToSignIn(ref _ICompleteCheck_Identity, this, _ICompleteCheck_SignedIn,
            ref centralKey);
        MF_SignInCompleteCheckCentral._ICompleteCheck_CheckOthers_Run_MarkCallerComplete(
            _ICompleteCheck_CentralCallBack_Check_Run_Complete);
    }


    public void _ICompleteCheck_CentralCallBack_Check_Run_Complete(int centralKey)
    {
        _commanderBattle = GetComponent<MF_CommanderBattle>();
        _movement = GetComponent<MF_PMovement>();
        _commanderAutoControl = GetComponent<MF_CommanderAutoControl>();
        _commanderSelfControl = GetComponent<MF_PCommanderSelfControl>();
        _commanderInfo = GetComponent<MF_CommanderInfo>();
        _ICompleteCheck_Completed = true;
    }
}
