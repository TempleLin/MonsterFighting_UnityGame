using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MF_NSettings.MF_NKeyInputs;
using UnityEngine.InputSystem;

namespace MF_NSettings
{
    public enum MF_ECommanderType
    {
        // Player1 sets to player0, Player2 sets to player1, AI sets to player1.
        Player1 = 0,
        Player2 = 1,
        AI = 2
    }

    public class MF_GameSettings : MonoBehaviour
    {
        [Space(10)] public MF_EGameType gameType;

        [Space(10)]
        //TODO Add AI settings
        public CommanderSettings[] commandersSettings = new CommanderSettings[2];

        //TODO Remove this temporary variable when finished.
        public InputActionAsset tempInputActionAsset;


        private void Start()
        {
            MF_EGameType tempGameType = MF_EGameType.LocalPVP;
            MF_EControlType[] tempControlTypes = {MF_EControlType.Keyboard, MF_EControlType.Xbox};
            InputActionMap[] tempInputActionMaps = {new PlayerInputs().Player1Battle, new PlayerInputs().Player2Battle};
            //TODO Remove this calling and call it from Commander's active setting.
            receiveGameSettings_pas(ref tempGameType, ref tempControlTypes, ref tempInputActionMaps);
        }

        [Serializable]
        public class CommanderSettings
        {
            public MF_ECommanderType commanderType;
            public MF_EControlType controlType;

            public InputActionMap inputActionMap;

            public CommanderSettings(MF_ECommanderType commanderType, ref MF_EControlType controlType, ref InputActionMap inputActionMap)
            {
                this.commanderType = commanderType;
                this.controlType = controlType;
                this.inputActionMap = inputActionMap;
            }
        }

        //InputActionMap and controlTypes might change during in-game player settings. Passing them by array can contain reference to commander's settings.
        //MF_EGameType does not need to change.
        public void receiveGameSettings_pas(ref MF_EGameType gameType, ref MF_EControlType[] controlTypes, ref InputActionMap[] inputActionMaps)
        {
            this.gameType = gameType;
            selfSetGameSettings_act(ref gameType, ref controlTypes, ref inputActionMaps);
        }

        private void selfSetGameSettings_act(ref MF_EGameType gameType, ref MF_EControlType[] controlTypes, ref InputActionMap[] inputActionMaps)
        {
            commandersSettings[0] = new CommanderSettings(MF_ECommanderType.Player1, ref controlTypes[0], ref inputActionMaps[0]);
            switch (gameType)
            {
                case MF_EGameType.LocalPVP:
                case MF_EGameType.NetworkPVP:
                    commandersSettings[1] = new CommanderSettings(MF_ECommanderType.Player2, ref controlTypes[1], ref inputActionMaps[1]);
                    break;
                case MF_EGameType.LocalPVAI:
                    commandersSettings[1] = new CommanderSettings(MF_ECommanderType.AI, ref controlTypes[1], ref inputActionMaps[1]);
                    break;
            }
        }
    }
}


