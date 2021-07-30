using System.Collections;
using System.Collections.Generic;
using MF_NSettings;
using UnityEngine;
using UnityEngine.InputSystem;

public enum MF_EStatus
{
    Idle,
    Running,
    Blocking,
    Dashing,
    Dodging,
    AffectedSpecial, // getting affected by enemy character's special ability
    KnockedAway,
    Punching,
    Kicking,
    Ulting,
    OnGround // Can't receive damage when completely on ground
}

public interface MF_IInfo
{
    int Health { get; }
    List<MF_EStatus> Statuses { get; }
    GameObject Enemy { get; }
    MF_ECommanderType CommanderType { get; }
    
    InputActionMap @InputActionMap { get; }

    public void infoInit(ref MF_ECommanderType commanderType, ref GameObject enemy, ref InputActionMap inputActionMap);
}
