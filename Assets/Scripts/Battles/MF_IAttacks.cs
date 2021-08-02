using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface MF_IAttacks
{
    int PunchComboIndex { get; }
    int KickComboIndex { get; }
    int punchCombo_Controlled();
    int kickCombo_Controlled();
    int ultimate_Controlled();
    void specialAffect_Controlled(GameObject player);
}
