using System.Collections.Generic;
using System.Collections.ObjectModel;
using MF_NSettings;
using UnityEngine;

public class MF_LocalManager : MonoBehaviour
{
    [SerializeField] private MF_GameSettings gameSettings;
    [SerializeField] private GameObject commanderPrefab;
    [Space(20)]
    [SerializeField] private Transform spawnPoint1;
    [SerializeField] private Transform spawnPoint2;

    private GameObject[] instantiateds = new GameObject[2];
    private CameraMultiTarget _cameraMultiTarget;

    void Start()
    {
        // Get the prefab if it isn't assigned (Shouldn't need this statement, but it's a weird bug.)
        if (commanderPrefab == null)
        {
            commanderPrefab = Resources.Load<GameObject>("Prefabs/MF_Commander");
        }
        
        _cameraMultiTarget = MF_InfoStation.Info.battlingCamera.GetComponent<CameraMultiTarget>();
        instantiateRegisterCommanders();
        startCommandersManagers();
    }

    private void instantiateRegisterCommanders()
    {
        switch (gameSettings.gameType)
        {
            case MF_EGameType.NetworkPVP:
                gameObject.SetActive(false);
                break;
            case MF_EGameType.LocalPVP:
            case MF_EGameType.LocalPVAI:
                instantiatePrefabs();
                registerCommanders();
                break;
        }

        void instantiatePrefabs()
        {
            instantiateds[0] = Instantiate(commanderPrefab, spawnPoint1.position, Quaternion.identity);
            instantiateds[1] = Instantiate(commanderPrefab, spawnPoint2.position, Quaternion.identity);
            _cameraMultiTarget.SetTargets(instantiateds);
        }

        void registerCommanders()
        {
            MF_InfoStation.Info.registeredCommandersShowBoard = new List<MF_InfoStation.RegisteredCommanders>()
            {
                new MF_InfoStation.RegisteredCommanders(ref gameSettings.commandersSettings[0].commanderType,
                    instantiateds[0], ref
                    gameSettings.commandersSettings[0].inputActionMap,
                    instantiateds[0].GetComponent<MF_CommanderInfo>()),
                new MF_InfoStation.RegisteredCommanders(ref gameSettings.commandersSettings[1].commanderType,
                    instantiateds[1], ref
                    gameSettings.commandersSettings[1].inputActionMap,
                    instantiateds[1].GetComponent<MF_CommanderInfo>())
            };

            MF_InfoStation.Info.registeredCommandersShowBoard[0].GameObject.GetComponent<MF_CommanderSettings>()
                .receiveSettings_pas(ref
                    gameSettings.commandersSettings[0].commanderType, ref instantiateds[1], ref
                    gameSettings.commandersSettings[0].inputActionMap, gameSettings.commandersSettings[0].health);
            MF_InfoStation.Info.registeredCommandersShowBoard[1].GameObject.GetComponent<MF_CommanderSettings>()
                .receiveSettings_pas(ref
                    gameSettings.commandersSettings[1].commanderType, ref instantiateds[0], ref
                    gameSettings.commandersSettings[1].inputActionMap, gameSettings.commandersSettings[1].health);
        
            MF_InfoStation.Info.registeredCommanders =
                new ReadOnlyCollection<MF_InfoStation.RegisteredCommanders>(MF_InfoStation.Info.registeredCommandersShowBoard);
        }
    }

    private void startCommandersManagers()
    {
        MF_InfoStation.Info.registeredCommandersShowBoard[0].GameObject.GetComponent<MF_CommanderManager>().startByManager();
        MF_InfoStation.Info.registeredCommandersShowBoard[1].GameObject.GetComponent<MF_CommanderManager>().startByManager();
    }
}
