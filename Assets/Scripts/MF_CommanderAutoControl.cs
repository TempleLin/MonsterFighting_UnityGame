using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MF_CommanderAutoControl : MonoBehaviour
{
    [SerializeField] private MF_CommanderInfo commanderInfo;

    [SerializeField] private MF_CommanderPlayerControl commanderPlayerControl;

    [SerializeField] private MF_PMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        //commanderInfo = 
        commanderPlayerControl = GetComponent<MF_CommanderPlayerControl>();
        playerMovement = GetComponent<MF_PMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement.move_Controlled(commanderPlayerControl.MovementVector);
    }
}
