using System.Collections;
using System.Collections.Generic;
using MF_NSettings;
using MF_NSettings.MF_NKeyInputs;
using UnityEngine;
using UnityEngine.InputSystem;

public class MF_CommanderInfo : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private MF_ECommanderType commanderType;
    [SerializeField] private List<MF_EStatus> statuses;
    [SerializeField] private InputActionMap inputActionMap;
    [SerializeField] private GameObject enemy;

    public int Health => health;
    public MF_ECommanderType CommanderType => commanderType;
    public List<MF_EStatus> Statuses => statuses;
    public InputActionMap @InputActionMap => inputActionMap;
    public GameObject Enemy => enemy;


    // Gets called from LocalManager or NetworkManager.
    public void infoInit(ref MF_ECommanderType commanderType, ref GameObject enemy, ref InputActionMap inputActionMap, int health)
    {
        this.commanderType = commanderType;
        //TODO Add NetworkPVP
        this.enemy = enemy;

        this.inputActionMap = inputActionMap;
        this.health = health;
    }
}
