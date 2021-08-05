
public static class MF_CodeStructure
{
    /*
     * @There are three types of commanders: Player1, Player2, and AI.
     * @MF_GameSettings are the settings given by Commanders.
     * @LocalManager and NetworkManager gameobjects with be the ones setting MF_InfoStation through MF_GameSettings.
     * @Players or AI prefab are spawned by LocalManager and NetworkManager.
     * @Information the commanders can get are accessed through MF_InfoStation, not MF_GameSettings.
     * @MF_CommanderInfo is the only info in spawned prefab that receives information set by LocalManager or NetworkManager.
     *
     */
    
    /*
     * @"_Controlled" in the end of method name means it gets called from class that ends with "Control". "pas" means it gets called from other
     * gameObjects.
     * @MF_CommanderPlayerControl is being controlled by commander; MF_CommanderAutoControl is controlled automatically from script.
     * @MF_CommanderInfo contains all information set from InfoStation that can be fetched and used by MF_CommanderManager.
     */
    
    /*
     * @Structure of the code: "Manager" always sets "Info" from "Setting" of the same hierarchy. 
     * For example: LocalManager sets InfoStation from GameSettings;
     * CommanderManager sets CommanderInfo from CommanderSettings.
     */
}
