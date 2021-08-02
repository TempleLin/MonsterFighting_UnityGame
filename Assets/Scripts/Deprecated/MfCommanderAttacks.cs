using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MfCommanderAttacks : MF_CommanderBattle, MF_IAttacks
{
    //TODO Implement attack status to info.
    private int temp = 0;
    [SerializeField] private bool enemyCollided = false;
    private delegate int defaultAttacks();

    private MF_IReceives receiver = null;
    
    public int punchCombo_Controlled()
    {
        Debug.Log("Punch");
        return temp;
    }

    public int kickCombo_Controlled()
    {
        Debug.Log("Kick");
        return temp + 1;
    }

    public int punch2_act()
    {
        Debug.Log("Punch2");
        return temp + 1;
    }

    public int punch3_act()
    {
        Debug.Log("Punch3");
        return temp + 2;
    }

    public int kick2_act()
    {
        Debug.Log("Kick2");
        return temp + 3;
    }

    public int kick3_act()
    {
        Debug.Log("Kick3");
        return temp + 4;
    }

    public int ultimate_Controlled()
    {
        Debug.Log("Ultimate");
        return temp + 5;
    }

    public void specialAffect_Controlled(GameObject player)
    {
        Debug.Log($"Special affecting {player.ToString()}");
    }
}
