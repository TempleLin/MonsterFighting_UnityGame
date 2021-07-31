using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MF_CommanderBattle : MonoBehaviour, MF_IAttacks, MF_IReceives
{
    //TODO Add all implementations
    
    #region MF_IAttacks
    public int punch_act()
    {
        throw new System.NotImplementedException();
    }

    public int kick_act()
    {
        throw new System.NotImplementedException();
    }

    public int punch2_act()
    {
        throw new System.NotImplementedException();
    }

    public int punch3_act()
    {
        throw new System.NotImplementedException();
    }

    public int kick2_act()
    {
        throw new System.NotImplementedException();
    }

    public int kick3_act()
    {
        throw new System.NotImplementedException();
    }

    public int ultimate_act()
    {
        throw new System.NotImplementedException();
    }

    public void specialAffect_act(GameObject player)
    {
        throw new System.NotImplementedException();
    }
    #endregion


    #region MF_IReceives
    public MF_IReceives.specialAffect_pas[] ReceiveSpecialAffect { get; set; }

    public void receiveDmg_pas(int dmg)
    {
        throw new System.NotImplementedException();
    }

    public void assistAttack_pas()
    {
        throw new System.NotImplementedException();
    }

    public void knockAway_pas(float seconds, float height)
    {
        throw new System.NotImplementedException();
    }
    #endregion

    
    //TODO Add sphere cast
}
