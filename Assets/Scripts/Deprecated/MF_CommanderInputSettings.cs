using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MF_NSettings.MF_NKeyInputs
{
    public enum MF_EControlType
    {
        Keyboard,
        Xbox,
        PS4,
        AI
    }
    [Serializable]
    public class MF_CommanderInputSettings
    {
        // TODO Change players keys & add more constructor types (Fix the not able to pass enum variable as argument issue)
        // TODO Check dash input
        public static readonly Dictionary<string, KeyCode> DefaultKeyboardKeys = new Dictionary<string, KeyCode>
        {
            {"Player1Up", KeyCode.W}, {"Player1Down", KeyCode.S}, {"Player1Left", KeyCode.A}, {"Player1Right", KeyCode.S},
            {"Player1Punch", KeyCode.J}, {"Player1Kick", KeyCode.K}, {"Player1Block", KeyCode.L}, {"Player1Ult", KeyCode.I},
            
            {"Player2Up", KeyCode.UpArrow}, {"Player2Down", KeyCode.DownArrow}, {"Player2Left", KeyCode.LeftArrow}, {"Player2Right", KeyCode.RightArrow}
        };
        public static readonly Dictionary<string, KeyCode> DefaultXboxKeys = new Dictionary<string, KeyCode>
        {

        };

        public static readonly Dictionary<string, KeyCode> DefaultPS4Keys = new Dictionary<string, KeyCode>
        {

        };

        public Dictionary<string, KeyCode> Player1Keys{ get; set; } = new Dictionary<string, KeyCode>();
        public Dictionary<string, KeyCode> Player2Keys{ get; set; } = new Dictionary<string, KeyCode>();
        
        
        public KeyCode upKey;
        public KeyCode downKey;
        public KeyCode leftKey;
        public KeyCode rightKey;

        public KeyCode punchKey;
        public KeyCode kickKey;
        public KeyCode blockKey;
        public KeyCode ultKey;
        public KeyCode dashKey;

        //TODO Add Player2 construction
        public MF_CommanderInputSettings(MF_ECommanderType commanderType, MF_EControlType controlType)
        {
            switch (commanderType)
            {
                case MF_ECommanderType.Player1:
                    switch (controlType)
                    {
                        //TODO Add Xbox and PS4 control input
                        case MF_EControlType.Keyboard:
                            upKey = KeyCode.W;
                            downKey = KeyCode.S;
                            leftKey = KeyCode.A;
                            rightKey = KeyCode.D;

                            punchKey = KeyCode.J;
                            kickKey = KeyCode.K;
                            blockKey = KeyCode.L;
                            ultKey = KeyCode.I;
                            dashKey = KeyCode.U;
                            break;
                        case MF_EControlType.Xbox:
                            break;
                        case MF_EControlType.PS4:
                            break;
                    }
                    break;
                    
                case MF_ECommanderType.Player2:
                    switch (controlType)
                    {
                        //TODO Add Xbox and PS4 control input
                        case MF_EControlType.Keyboard:
                            upKey = KeyCode.UpArrow;
                            downKey = KeyCode.DownArrow;
                            leftKey = KeyCode.LeftArrow;
                            rightKey = KeyCode.RightArrow;

                            punchKey = KeyCode.J;
                            kickKey = KeyCode.K;
                            blockKey = KeyCode.L;
                            ultKey = KeyCode.I;
                            dashKey = KeyCode.U;
                            break;
                        case MF_EControlType.Xbox:
                            break;
                        case MF_EControlType.PS4:
                            break;
                    }
                    break;
            }
        }
        
        //TODO Modify this.
        public void setNewKeyByUserInput()
        {
            foreach(KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))){
                if(Input.GetKey(vKey)){
                    //your code here
                 
                }
            }
        }
    }
}

