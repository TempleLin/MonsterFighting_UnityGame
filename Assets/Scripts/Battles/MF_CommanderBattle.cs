using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MF_CommanderBattle : MonoBehaviour, MF_IAttacks, MF_IReceives
{
    [SerializeField] private int punchComboMax = 3;
    private int punchComboIndex = 0;
    public int PunchComboIndex => punchComboIndex;

    [SerializeField] private int kickComboMax = 3;
    private int kickComboIndex = 0;
    public int KickComboIndex => kickComboIndex;

    private delegate void combos();

    private combos[] punchCombos = new combos[]
    {
        delegate() {  },
        delegate() {  }, 
        delegate() {  }, 
    };

    private combos[] kickCombos = new combos[]
    {
        delegate() {  },
        delegate() {  }, 
        delegate() {  }, 
    };

        //TODO Add all implementations
    
    #region MF_IAttacks
    public int punchCombo_Controlled()
    {
        punchComboIndex = (punchComboIndex >= punchComboMax)? 1 : punchComboIndex + 1;
        punchCombos[punchComboIndex]();
        throw new System.NotImplementedException();
    }

    public int kickCombo_Controlled()
    {
        kickComboIndex = (kickComboIndex >= kickComboMax)? 1 : kickComboIndex + 1;
        punchCombos[kickComboIndex]();
        throw new System.NotImplementedException();
    }
    public int ultimate_Controlled()
    {
        throw new System.NotImplementedException();
    }

    public void specialAffect_Controlled(GameObject player)
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
