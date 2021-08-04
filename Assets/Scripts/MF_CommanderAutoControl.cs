using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MF_CommanderAutoControl : MonoBehaviour, MF_ISignInCompleteCheck
{
    private static int sameTypeIdentityCount = 0;
    private string _ICompleteCheck_Identity = "CommanderAutoControl" + sameTypeIdentityCount++;
    public string ICompleteCheck_Identity => _ICompleteCheck_Identity;
    private bool _ICompleteCheck_Completed;
    public bool ICompleteCheck_Completed => _ICompleteCheck_Completed;
    private ValueWrapper<bool> _ICompleteCheck_SignedIn = new ValueWrapper<bool>(false);
    public ValueWrapper<bool> ICompleteCheck_SignedIn => _ICompleteCheck_SignedIn;
    private int centralKey;
    
    [SerializeField] private MF_CommanderInfo commanderInfo;

    [SerializeField] private MF_PCommanderControl commanderControl;

    [SerializeField] private MF_PMovement movement;
    void Start()
    {
        commanderControl = GetComponent<MF_PCommanderControl>();
        movement = GetComponent<MF_PMovement>();
        MF_SignInCompleteCheckCentral.getCalledToSignIn(ref _ICompleteCheck_Identity, this, _ICompleteCheck_SignedIn, ref centralKey);
    }

    void Update()
    {
        movement.move_Controlled(commanderControl.MovementVector);
    }


    public void _ICompleteCheck_CentralCallBack_Check_Run_Complete(int centralKey)
    {
        MF_SignInCompleteCheckCentral._ICompleteCheck_WaitForComplete(GetComponent<MF_CommanderManager>().ICompleteCheck_Identity);

    }
}
