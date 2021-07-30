using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface MF_IAttacks
{
    int punch_act();
    int kick_act();
    int punch2_act();
    int punch3_act();
    int kick2_act();
    int kick3_act();
    int ultimate_act();
    void specialAffect_act(GameObject player);
}
