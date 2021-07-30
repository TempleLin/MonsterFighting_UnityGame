using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface MF_ISignInCompleteCheck
{
    string ICompleteCheck_Identity { get; } 
    bool ICompleteCheck_Completed { get; }
    ValueWrapper<bool> ICompleteCheck_SignedIn { get; }
    
    // The passed in argument must be from Central.
    void _ICompleteCheck_CentralCallBack_Check_Run_Complete(int centralKey);
}
