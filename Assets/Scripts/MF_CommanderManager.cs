using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MF_CommanderManager : MonoBehaviour, MF_ISignInCompleteCheck
{
    private static int sameTypeIdentityCount = 0;
    private string _ICompleteCheck_Identity = "CommanderManager" + sameTypeIdentityCount++;
    public string ICompleteCheck_Identity => _ICompleteCheck_Identity;
    private bool _ICompleteCheck_Completed;
    public bool ICompleteCheck_Completed => _ICompleteCheck_Completed;
    public ValueWrapper<bool> _ICompleteCheck_SignedIn = new ValueWrapper<bool>(false);
    public ValueWrapper<bool> ICompleteCheck_SignedIn => _ICompleteCheck_SignedIn;
    private int centralKey;
    
    [SerializeField] private MF_PlayerMovement playerMovement;
    [SerializeField] private MF_PlayerCommanderControl commanderControl;
    void Start()
    {
        MF_SignInCompleteCheckCentral._ICompleteCheck_WaitForComplete(GetComponent<MF_CommanderInfo>().ICompleteCheck_Identity);
        MF_SignInCompleteCheckCentral.getCalledToSignIn(ref _ICompleteCheck_Identity, this, _ICompleteCheck_SignedIn, ref centralKey);
        
        // TODO Needs to add modification code to decide whether turn the gameObject into a player or an AI
        playerMovement = GetComponent<MF_PlayerMovement>();
        commanderControl = GetComponent<MF_PlayerCommanderControl>();
        MF_SignInCompleteCheckCentral._ICompleteCheck_CheckOthers_Run_MarkCallerComplete(_ICompleteCheck_CentralCallBack_Check_Run_Complete);
    }
    
    void Update()
    {
        playerMovement.move_Controlled(commanderControl.MovementVector);
    }


    public void _ICompleteCheck_CentralCallBack_Check_Run_Complete(int centralKey)
    {
        if (centralKey != this.centralKey)
        {
            Debug.Log("Central key not right.");
            return;
        }

        _ICompleteCheck_Completed = true;
    }
}
