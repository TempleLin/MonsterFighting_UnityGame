using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MF_PlayerMovement : MF_PMovement
{
    public override void move_Controlled(Vector2 moveValue)
    {
        if (moveValue == Vector2.zero)
        {
            try
            {
                transform.rotation = Quaternion.Slerp(transform.rotation,
                    Quaternion.LookRotation(info.Enemy.transform.position - transform.position), 0.03f);
            }
            catch (NullReferenceException e)
            {
            }
            return;
        }

        Vector3 movement = new Vector3(moveValue.x * moveSpeed, 0, moveValue.y * moveSpeed);
        navMeshAgent.Move(movement);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.03f);
        Debug.Log("Move");
    }
}
