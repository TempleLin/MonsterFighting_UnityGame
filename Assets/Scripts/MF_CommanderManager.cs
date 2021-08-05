using System.Collections.Generic;
using MF_NSettings;
using Mirror;
using UnityEngine;

public class MF_CommanderManager : MonoBehaviour, MF_IStartByManager
{
    [SerializeField] private MF_CommanderInfo commanderInfo;
    [SerializeField] private MF_CommanderSettings commanderSettings;
    private List<MF_IStartByManager> toStarts = new List<MF_IStartByManager>();

    public void startByManager()
    {
        setInfoFromSettings();
        addRemoveCommanderComponents();
        startAllComponents();
    }

    private void setInfoFromSettings()
    {
        commanderInfo = GetComponent<MF_CommanderInfo>();
        commanderSettings = GetComponent<MF_CommanderSettings>();
        commanderInfo.infoInit(ref commanderSettings.commanderType, ref commanderSettings.enemy,
            ref commanderSettings.inputActionMap, commanderSettings.health);
    }

    private void addRemoveCommanderComponents()
    {
        gameObject.AddComponent<MF_CommanderBattle>();
        toStarts.Add(gameObject.AddComponent<MF_CommanderScriptComponentsLink>());   
        // TODO Needs to add modification code to decide whether turn the gameObject into a player or an AI
        switch (commanderInfo.CommanderType)
        {
            case MF_ECommanderType.Player1:
            case MF_ECommanderType.Player2:
                gameObject.AddComponent<MF_PlayerMovement>();
                toStarts.Add(gameObject.AddComponent<MF_CommanderAutoControl>());
                toStarts.Add(gameObject.AddComponent<MF_CommanderPlayerControl>());
                Destroy(GetComponent<NetworkTransform>());
                Destroy(GetComponent<NetworkIdentity>());
                break;
            case MF_ECommanderType.AI:
                gameObject.AddComponent<MF_AIMovement>();
                toStarts.Add(gameObject.AddComponent<MF_CommanderAutoControl>());
                toStarts.Add(gameObject.AddComponent<MF_CommanderAIControl>());
                break;
        }
    }

    private void startAllComponents()
    {
        foreach (var toStart in toStarts)
        {
            toStart.startByManager();
        }
    }

}
