using System.Collections;
using System.Collections.Generic;
using MF_NSettings;
using Mirror;
using UnityEngine;

public class MF_CommanderManager : MonoBehaviour
{
    [SerializeField] private MF_CommanderInfo commanderInfo;
    private List<MF_IStartByManager> toStarts = new List<MF_IStartByManager>();

    void Start()
    {
        commanderInfo = GetComponent<MF_CommanderInfo>();
        addRemoveCommanderComponents();
        startAllComponents();
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
