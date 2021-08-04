using System.Collections;
using System.Collections.Generic;
using MF_NSettings;
using Mirror;
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
    
    [SerializeField] private MF_CommanderInfo commanderInfo;
    
    void Start()
    {
        MF_SignInCompleteCheckCentral.getCalledToSignIn(ref _ICompleteCheck_Identity, this, _ICompleteCheck_SignedIn, ref centralKey);
        MF_SignInCompleteCheckCentral._ICompleteCheck_CheckOthers_Run_MarkCallerComplete(_ICompleteCheck_CentralCallBack_Check_Run_Complete);
    }

    private void setCommanderComponents()
    {
        // TODO Needs to add modification code to decide whether turn the gameObject into a player or an AI
        switch (commanderInfo.CommanderType)
        {
            case MF_ECommanderType.Player1:
            case MF_ECommanderType.Player2:
                gameObject.AddComponent<MF_PlayerMovement>();
                gameObject.AddComponent<MF_CommanderPlayerControl>();
                Destroy(GetComponent<NetworkTransform>());
                Destroy(GetComponent<NetworkIdentity>());
                break;
            case MF_ECommanderType.AI:
                gameObject.AddComponent<MF_AIMovement>();
                gameObject.AddComponent<MF_CommanderAIControl>();
                break;
        }
    }

    public void _ICompleteCheck_CentralCallBack_Check_Run_Complete(int centralKey)
    {
        if (centralKey != this.centralKey)
        {
            Debug.LogWarning("Central key not right.");
            return;
        }
        MF_SignInCompleteCheckCentral._ICompleteCheck_WaitForComplete(GetComponent<MF_CommanderInfo>().ICompleteCheck_Identity);

        commanderInfo = GetComponent<MF_CommanderInfo>();
        setCommanderComponents();
        
        _ICompleteCheck_Completed = true;
    }
}
