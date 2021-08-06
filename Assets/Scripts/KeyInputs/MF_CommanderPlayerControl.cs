using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MF_CommanderPlayerControl : MF_PCommanderSelfControl, MF_IStartByManager
{
    [SerializeField] private InputActionMap inputActionMap;

    private MF_CommanderScriptComponentsLink otherScriptComponents;
    private MF_CommanderAutoControl commanderAutoControl;
 
    public void startByManager()
    {
        otherScriptComponents = GetComponent<MF_CommanderScriptComponentsLink>();
        commanderAutoControl = otherScriptComponents.CommanderAutoControl;

        inputActionMap = otherScriptComponents.CommanderInfo.InputActionMap;
        inputActionMap.Enable();
        inputActionMap.actions[0].performed += ctx => playerMovement_Hold(ctx);
        inputActionMap.actions[1].performed += _ => playerPunchCombo_press();
        inputActionMap.actions[2].performed += _ => playerKickCombo_press();
        //TODO Add more input controls performed
    }   

    private void playerMovement_Hold(InputAction.CallbackContext ctx)
    {
        Debug.Log("Hold");
        Debug.Log($"Moving {ctx.ReadValue<Vector2>()}.");
        commanderAutoControl.MovementVector = ctx.ReadValue<Vector2>();
    }

    private void playerPunchCombo_press()
    {
        otherScriptComponents.CommanderBattle.punchCombo_Controlled();
    }

    private void playerKickCombo_press()
    {
        otherScriptComponents.CommanderBattle.kickCombo_Controlled();
    }
    
    private void OnDisable()
    {
        inputActionMap.Disable();
    }

    // return bool in hurtable (Not hurtable when on ground or blocking), also out bool in range 
    private bool hurtable_InRange(out bool inRange)
    {
        //TODO Set canAttack_InRange method and check return value by judging from statuses.
        //TODO Needs to add judgement about if enemy can dodge the attack.
        
        inRange = commanderAutoControl.EnemyInRange.Value;
        List<MF_EStatus> statuses = otherScriptComponents.CommanderInfo.Statuses;
        
        for (int i = 0; i < statuses.Count; i++)
        {
            if (statuses[i] == MF_EStatus.Blocking || statuses[i] == MF_EStatus.OnGround)
                return false;
        }

        return true;
    }
}
