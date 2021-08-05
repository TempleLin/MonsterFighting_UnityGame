using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MF_CommanderScriptComponentsLink : MonoBehaviour, MF_IStartByManager
{
    [SerializeField] public MF_CommanderInfo _commanderInfo;
    [SerializeField] public MF_CommanderBattle _commanderBattle;
    [SerializeField] public MF_PMovement _movement;
    [SerializeField] public MF_CommanderAutoControl _commanderAutoControl;
    [SerializeField] public MF_PCommanderSelfControl _commanderSelfControl;

    public MF_CommanderInfo CommanderInfo => _commanderInfo;
    public MF_CommanderBattle CommanderBattle => _commanderBattle;
    public MF_PMovement Movement => _movement;
    public MF_CommanderAutoControl CommanderAutoControl => _commanderAutoControl;
    public MF_PCommanderSelfControl CommanderSelfControl => _commanderSelfControl;

    public void startByManager()
    {
        _commanderBattle = GetComponent<MF_CommanderBattle>();
        _movement = GetComponent<MF_PMovement>();
        _commanderAutoControl = GetComponent<MF_CommanderAutoControl>();
        _commanderSelfControl = GetComponent<MF_PCommanderSelfControl>();
        _commanderInfo = GetComponent<MF_CommanderInfo>();
    }
}
