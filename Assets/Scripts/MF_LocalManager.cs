using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MF_NSettings;
using Unity.Mathematics;
using UnityEngine;

public class MF_LocalManager : MonoBehaviour, MF_ISignInCompleteCheck
{
    private bool _ICompleteCheck_Completed = false;
    public bool ICompleteCheck_Completed => _ICompleteCheck_Completed;
    private ValueWrapper<bool> _ICompleteCheck_SignedIn = new ValueWrapper<bool>(false);
    public ValueWrapper<bool> ICompleteCheck_SignedIn => _ICompleteCheck_SignedIn;
    private string _ICompleteCheck_Identity = "LocalManager";
    public string ICompleteCheck_Identity  => _ICompleteCheck_Identity;
    private int centralKey;
    
    
    [SerializeField] private MF_GameSettings gameSettings;

    [SerializeField] private GameObject commanderPrefab;

    [Space(20)]
    [SerializeField] private Transform spawnPoint1;
    [SerializeField] private Transform spawnPoint2;

    private GameObject[] instantiateds = new GameObject[2];

    private CameraMultiTarget _cameraMultiTarget;

    void Start()
    {
        MF_SignInCompleteCheckCentral.getCalledToSignIn(ref _ICompleteCheck_Identity, this, ICompleteCheck_SignedIn, ref centralKey);

        // Get the prefab if it isn't assigned (Shouldn't need this statement, but it's a weird bug.)
        if (commanderPrefab == null)
        {
            commanderPrefab = Resources.Load<GameObject>("Prefabs/MF_Commander");
        }
        
        _cameraMultiTarget = MF_InfoStation.info.battlingCamera.GetComponent<CameraMultiTarget>();
        instantiateRegisterCommanders();

        MF_SignInCompleteCheckCentral._ICompleteCheck_CheckOthers_Run_MarkCallerComplete(_ICompleteCheck_CentralCallBack_Check_Run_Complete);
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
            MF_InfoStation.info.registeredCommandersShowBoard = new List<MF_InfoStation.RegisteredCommanders>()
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

            MF_InfoStation.info.registeredCommandersShowBoard[0].Info.infoInit(ref
                gameSettings.commandersSettings[0].commanderType, ref instantiateds[1], ref
                gameSettings.commandersSettings[0].inputActionMap);
            MF_InfoStation.info.registeredCommandersShowBoard[1].Info.infoInit(ref
                gameSettings.commandersSettings[1].commanderType, ref instantiateds[0], ref
                gameSettings.commandersSettings[1].inputActionMap);
        
            MF_InfoStation.info.registeredCommanders =
                new ReadOnlyCollection<MF_InfoStation.RegisteredCommanders>(MF_InfoStation.info.registeredCommandersShowBoard);
        }
    }

    public void _ICompleteCheck_CentralCallBack_Check_Run_Complete(int centralKey)
    {
        if (centralKey != this.centralKey) return;
        if (MF_SignInCompleteCheckCentral._ICompleteCheck_CheckSignedInAndComplete("CommanderInfo1") &&
            MF_SignInCompleteCheckCentral._ICompleteCheck_CheckSignedInAndComplete("CommanderInfo2"))
        {
            _ICompleteCheck_Completed = true;
        }
        else
        {
            Debug.LogWarning("Commanders not completed. Can't complete LocalManager.");
        }
    }
}
