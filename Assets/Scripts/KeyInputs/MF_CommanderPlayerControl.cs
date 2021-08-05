using UnityEngine;
using UnityEngine.InputSystem;

public class MF_CommanderPlayerControl : MF_PCommanderSelfControl, MF_IStartByManager
{
    [SerializeField] private InputActionMap inputActionMap;

    [SerializeField] private MF_CommanderScriptComponentsLink otherScriptComponents;
    

    private void OnDisable()
    {
        inputActionMap.Disable();
    }
    
    private void playerMovement_Hold(InputAction.CallbackContext ctx)
    {
        Debug.Log("Hold");
        Debug.Log($"Moving {ctx.ReadValue<Vector2>()}.");
        movementVector = ctx.ReadValue<Vector2>();
        otherScriptComponents.Movement.move_Controlled(movementVector);
    }

    private void playerPunchCombo_press()
    {
        otherScriptComponents.CommanderBattle.punchCombo_Controlled();
    }

    private void playerKickCombo_press()
    {
        otherScriptComponents.CommanderBattle.kickCombo_Controlled();
    }

    public void startByManager()
    {
        otherScriptComponents = GetComponent<MF_CommanderScriptComponentsLink>();

        inputActionMap = otherScriptComponents.CommanderInfo.InputActionMap;
        inputActionMap.Enable();
        inputActionMap.actions[0].performed += ctx => playerMovement_Hold(ctx);
        inputActionMap.actions[1].performed += _ => playerPunchCombo_press();
        inputActionMap.actions[2].performed += _ => playerKickCombo_press();
        //TODO Add more input controls performed
    }
}
