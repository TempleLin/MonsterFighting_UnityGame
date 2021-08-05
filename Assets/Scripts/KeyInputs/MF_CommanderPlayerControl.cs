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

}
