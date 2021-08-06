using System;
using UnityEngine;

public class MF_CommanderAutoControl : MonoBehaviour, MF_IStartByManager
{
    private MF_CommanderScriptComponentsLink otherScriptComponents;
    private ValueWrapper<bool> enemyInRange = new ValueWrapper<bool>(false);
    [SerializeField] private float enemyDistance;
    private Vector2 movementVector;
    public ValueWrapper<bool> EnemyInRange => enemyInRange;
    public Vector2 MovementVector
    {
        get => movementVector;
        set
        {
            movementVector = value;
        }
    }

    void Update()
    {
        moving();
        calculateEnemyDistance();
    }

    private void moving()
    {
        otherScriptComponents.Movement.move_Controlled(movementVector);
    }
    
    public void startByManager()
    {
        otherScriptComponents = GetComponent<MF_CommanderScriptComponentsLink>();
    }

    private void calculateEnemyDistance()
    {
        enemyDistance = Vector3.Distance(otherScriptComponents.CommanderInfo.Enemy.transform.position,
            transform.position);
    }

    
}
