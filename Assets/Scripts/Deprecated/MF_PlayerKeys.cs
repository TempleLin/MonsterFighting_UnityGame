using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MF_NSettings.MF_NKeyInputs
{
    [Serializable]
    public class MF_PlayerKeys
    {
        // TODO Design PlayerKeys
        public InputAction playerInputs;
        MF_PlayerKeys(MF_EControlType controlType)
        {
            switch (controlType)
            {
                case MF_EControlType.Keyboard:
                
                    break;
                case MF_EControlType.Xbox:
                    break;
                case MF_EControlType.PS4:
                    break;
            }
        }
    }
}


