using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MF_CodeStructure
{
    /*
     * @There are three types of commanders: Player1, Player2, and AI.
     * @MF_GameSettings are the settings given by Commanders.
     * @LocalManager and NetworkManager gameobjects with be the ones setting MF_InfoStation through MF_GameSettings.
     * @Players or AI prefab are spawned by LocalManager and NetworkManager.
     * @Information the commanders can get are accessed through MF_InfoStation, not MF_GameSettings.
     * @MF_CommanderInfo is the only info in spawned prefab that receives information set by Manager.
     *
     * @MF_SignInCompleteCheckCentral is a design pattern that acts as a central for components to inherit MF_ISignInCompleteCheck interface
     * and sign in to this central on code start, and can know when other component that have signed this interface has completed its code
     * by accessing this central.
     */
    
    /*
     * @"pas" in the end of the method name means it gets called from outside. "act" means it gets called by the class itself. 
     */
}
