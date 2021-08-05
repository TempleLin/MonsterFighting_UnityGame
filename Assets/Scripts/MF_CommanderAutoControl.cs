using System;
using UnityEngine;

public class MF_CommanderAutoControl : MonoBehaviour, MF_IStartByManager
{
    [SerializeField] private MF_CommanderScriptComponentsLink otherScriptComponents;

    void Update()
    {
        try
        {
            otherScriptComponents.Movement.move_Controlled(otherScriptComponents.CommanderSelfControl
                .MovementVector);
        }
        catch (NullReferenceException e)
        {
        }
    }

    public void startByManager()
    {
        otherScriptComponents = GetComponent<MF_CommanderScriptComponentsLink>();
    }
}
