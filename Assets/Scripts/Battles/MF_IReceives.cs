using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// act means active player action, pas means passive player action
public interface MF_IReceives
{
    /*
     * Receives special effects the from enemy character type attack.
     * Receive by adding to delegate array "ReceiveSpecialAffect" from enemy.
     * First one gets called from this player. Delete the first one.
     */
    delegate void specialAffect_pas(GameObject player);
    specialAffect_pas[] ReceiveSpecialAffect { set; }

    /*
     * Remember to write if is blocking then don't receive damage.
     */
    void receiveDmg_pas(int dmg);
    void assistAttack_pas();
    void knockAway_pas(float seconds, float height);
}
