using System.Collections;
using System.Collections.Generic;
using MF_NSettings;
using MF_NSettings.MF_NKeyInputs;
using UnityEngine;
using UnityEngine.InputSystem;

public class MF_CommanderInfo : MonoBehaviour, MF_IInfo, MF_ISignInCompleteCheck
{
    private bool _ICompleteCheck_Completed = false;
    private static int sameTypeIdentityCount = 0;
    private string _ICompleteCheck_Identity = "CommanderInfo" + sameTypeIdentityCount++;
    private ValueWrapper<bool> _ICompleteCheck_SignedIn = new ValueWrapper<bool>(false);
    private int centralKey;
    
    [SerializeField] private int health = 100;
    [SerializeField] private MF_ECommanderType commanderType;
    [SerializeField] private List<MF_EStatus> statuses;
    [SerializeField] private InputActionMap inputActionMap;
    [SerializeField] private GameObject enemy;
    
    public bool ICompleteCheck_Completed => _ICompleteCheck_Completed;
    public string ICompleteCheck_Identity => _ICompleteCheck_Identity;
    public ValueWrapper<bool> ICompleteCheck_SignedIn => _ICompleteCheck_SignedIn;
    public int Health => health;
    public MF_ECommanderType CommanderType => commanderType;
    public List<MF_EStatus> Statuses => statuses;
    public InputActionMap @InputActionMap => inputActionMap;
    public GameObject Enemy => enemy;


    // Gets called from LocalManager or NetworkManager.
    public void infoInit(ref MF_ECommanderType commanderType, ref GameObject enemy, ref InputActionMap inputActionMap)
    {
        MF_SignInCompleteCheckCentral.getCalledToSignIn(ref _ICompleteCheck_Identity, this, _ICompleteCheck_SignedIn, ref centralKey);
        
        this.commanderType = commanderType;
        //TODO Add NetworkPVP
        this.enemy = enemy;

        this.inputActionMap = inputActionMap;
        
        MF_SignInCompleteCheckCentral._ICompleteCheck_CheckOthers_Run_MarkCallerComplete(_ICompleteCheck_CentralCallBack_Check_Run_Complete);
    }

    public void _ICompleteCheck_CentralCallBack_Check_Run_Complete(int centralKey)
    {
        if (centralKey != this.centralKey) return;
        _ICompleteCheck_Completed = true;
    }
}
