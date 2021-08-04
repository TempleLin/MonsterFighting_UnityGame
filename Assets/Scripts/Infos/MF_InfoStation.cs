using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using JetBrains.Annotations;
using MF_NSettings;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public enum MF_EGameType
{
    LocalPVP,
    NetworkPVP,
    LocalPVAI
}

public class MF_InfoStation : MonoBehaviour, MF_ISignInCompleteCheck
{
    // Access this component by this variable. (Similar to Singleton)
    private static MF_InfoStation info;
    public static MF_InfoStation Info => info;
    
    public Camera battlingCamera;

    public List<RegisteredCommanders> registeredCommandersShowBoard;
    public ReadOnlyCollection<RegisteredCommanders> registeredCommanders;

    private string _ICompleteCheck_Identity = "InfoStation";
    private bool _ICompleteCheck_Completed = false;
    private ValueWrapper<bool> _ICompleteCheck_SignedIn = new ValueWrapper<bool>(false);
    private int centralKey;
    
    public string ICompleteCheck_Identity => _ICompleteCheck_Identity;
    public bool ICompleteCheck_Completed => _ICompleteCheck_Completed;
    public ValueWrapper<bool> ICompleteCheck_SignedIn => _ICompleteCheck_SignedIn;


    private void Awake()
    {
        if (info == null)
            info = GetComponent<MF_InfoStation>();
        else
        {
            Destroy(this);
            Debug.Log("More than one MF_InfoStation.");
            Debug.Break();
        }
    }

    private void Start()
    {
        MF_SignInCompleteCheckCentral.getCalledToSignIn(ref _ICompleteCheck_Identity, this, _ICompleteCheck_SignedIn, ref centralKey);
        MF_SignInCompleteCheckCentral._ICompleteCheck_CheckOthers_Run_MarkCallerComplete(_ICompleteCheck_CentralCallBack_Check_Run_Complete);
    }

    [Serializable]
    public class RegisteredCommanders
    {
        [SerializeField]private MF_ECommanderType commanderType;
        public MF_ECommanderType CommanderType => commanderType;
        [SerializeField]private GameObject _gameObject;
        public GameObject @GameObject => _gameObject;
        [SerializeField] private MF_CommanderInfo info;
        public MF_CommanderInfo Info => info;
        [SerializeField] private InputActionMap inputActionMap;
        public InputActionMap @InputActionMap => inputActionMap;

        public RegisteredCommanders(ref MF_ECommanderType commanderType, GameObject gameObject, ref InputActionMap inputActionMap, MF_CommanderInfo info = null)
        {
            this.commanderType = commanderType;
            _gameObject = gameObject;
            this.inputActionMap = inputActionMap;
            this.info = info;
        }
    }

    public RegisteredCommanders getRegisteredByCommanderType(MF_ECommanderType commanderType)
    {
        IEnumerable<RegisteredCommanders> registereds =
            from _registeredGameObjects in registeredCommanders
            where _registeredGameObjects.CommanderType == commanderType
            select _registeredGameObjects;

        foreach (var _registereds in registereds)
        {
            return _registereds;
        }

        // If no matches, return "NoMatch".
        throw new NoRegisteredCommanderException(commanderType.ToString());
    }


    [Serializable]
    private class NoRegisteredCommanderException : Exception
    {
        public NoRegisteredCommanderException()
        {
        }

        public NoRegisteredCommanderException(string commanderType) : base(
            String.Format($"Can't find: {commanderType}"))
        {
            
        }
    }
    
    public void _ICompleteCheck_CentralCallBack_Check_Run_Complete(int centralKey)
    {
        if (centralKey != this.centralKey) return;
        if (_ICompleteCheck_Completed) return;
        _ICompleteCheck_Completed = true;
    }
}
