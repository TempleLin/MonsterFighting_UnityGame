using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MF_PlayerManager : MonoBehaviour
{
    [SerializeField] private MF_PlayerMovement playerMovement;
    [SerializeField] private MF_PlayerInputsBind inputsBind;
    void Start()
    {
        playerMovement = GetComponent<MF_PlayerMovement>();
        inputsBind = GetComponent<MF_PlayerInputsBind>();
    }
    
    void Update()
    {
        playerMovement.move_Controlled(inputsBind.MovementVector);
    }
}
