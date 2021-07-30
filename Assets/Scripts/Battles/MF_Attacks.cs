using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MF_Attacks : MF_PBattle, MF_IAttacks
{
    //TODO Implement attack status to info.
    private int temp = 0;
    [SerializeField] private bool enemyCollided = false;
    private delegate int defaultAttacks();

    private MF_IReceives receiver = null;
    
    public int punch_act()
    {
        Debug.Log("Punch");
        return temp;
    }

    public int kick_act()
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

    public int ultimate_act()
    {
        Debug.Log("Ultimate");
        return temp + 5;
    }

    public void specialAffect_act(GameObject player)
    {
        Debug.Log($"Special affecting {player.ToString()}");
    }

    // private void OnCollisionEnter(Collision other)
    // {
    //     if (other.gameObject.GetComponent<MF_Receives>() is MF_IReceives && receiver == null && other.gameObject != gameObject)
    //         receiver = other.gameObject.GetComponent<MF_Receives>();
    // }

    // private void OnCollisionExit(Collision other)
    // {
    //     receiver = null;
    // }

    // private void OnCollisionStay(Collision other)
    // {
    //     if (other.gameObject.CompareTag("Player"))
    //         Debug.Log("OnCollisionStay");
    //     //TODO Implement IReceives and optimize this code
    //     if (Input.GetKeyDown(KeyCode.E) && other.gameObject.CompareTag("Player"))
    //     {
    //         receiver.receiveDmg_pas(punch_act());
    //     }
    // }
}
