using MF_NSettings;
using UnityEngine;
using UnityEngine.InputSystem;

public class MF_CommanderSettings : MonoBehaviour
{
    public int health;
    public MF_ECommanderType commanderType;
    public InputActionMap inputActionMap;
    public GameObject enemy;

    public void receiveSettings_pas(ref MF_ECommanderType commanderType, ref GameObject enemy,
        ref InputActionMap inputActionMap, int health)
    {
        this.commanderType = commanderType;
        //TODO Add NetworkPVP
        this.enemy = enemy;

        this.inputActionMap = inputActionMap;
        this.health = health;
    }

    // Only needed if there's decision making.
    public void selfSetSettings_act(ref MF_ECommanderType commanderType, ref GameObject enemy,
        ref InputActionMap inputActionMap, int health)
    {

    }
}
