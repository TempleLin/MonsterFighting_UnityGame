using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MF_SignInCompleteCheckCentral
{
    private static Dictionary<string, MF_ISignInCompleteCheck> signedInCompleteChecks = new Dictionary<string, MF_ISignInCompleteCheck>();

    private static int centralKey = 012;

    // centralKey is to pass to other components that signed interface a centralKey, so that when callback from "_ICompleteCheck_CheckOthers_Run_MarkCallerComplete",
    // the components can check if the callback is from Central.
    public static void getCalledToSignIn(ref string identity, MF_ISignInCompleteCheck _MF_ISignInCompleteCheck, ValueWrapper<bool> _ICompleteCheck_SignedIn, ref int _centralKey)
    {
        Debug.Log($"{identity} signed in.");
        signedInCompleteChecks.Add(identity, _MF_ISignInCompleteCheck);
        _centralKey = centralKey; 
        _ICompleteCheck_SignedIn.Value = true;
    }

    public static MF_ISignInCompleteCheck getOtherByIdentity(string identity)
    {
        try
        {
            return signedInCompleteChecks[identity];
        }
        catch (KeyNotFoundException e)
        {
            //TODO Add throw exception
            Debug.LogWarning($"{identity} is not registered.");
            throw;
        }
    }

    public static void _ICompleteCheck_CheckOthers_Run_MarkCallerComplete(Action<int> callbackWithCentralKey)
    {
        callbackWithCentralKey(MF_SignInCompleteCheckCentral.centralKey);
    }
}
