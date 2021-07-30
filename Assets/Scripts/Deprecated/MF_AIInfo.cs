using System.Collections;
using System.Collections.Generic;
using MF_NSettings;
using UnityEngine;

public class MF_AIInfo : MonoBehaviour
{
    // Access this component through this variable.
    public static MF_AIInfo info;
    
    void Start()
    {
        info = GetComponent<MF_AIInfo>();
        
        //Statuses.Add(EStatus.Idle);
    }
    
    public void infoInit(MF_ECommanderType commanderType, GameObject enemy)
    {
        //base.infoInit(commanderType, enemy);
    }
}
