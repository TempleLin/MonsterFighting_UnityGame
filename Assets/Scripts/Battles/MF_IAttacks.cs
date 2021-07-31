using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface MF_IAttacks
{
    int PunchComboIndex { get; }
    int KickComboIndex { get; }
    int punchCombo_act();
    int kickCombo_act();
    int ultimate_act();
    void specialAffect_act(GameObject player);
}
