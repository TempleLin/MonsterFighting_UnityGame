using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidPoint : MonoBehaviour
{
    [SerializeField] private Transform midPoint;
    [SerializeField] private List<Transform> targets;

    [SerializeField] private float rotateSpeed; 

    private Transform mainTarget;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        setMidPoint();
        midPointRotate();
    }

    void setMidPoint()
    {
        Vector3 directionToTarget0 = targets[0].position - midPoint.position;
        Vector3 directionToTarget1 = targets[1].position - midPoint.position;
        // midPoint.position = (directionToTarget0 + directionToTarget1) / 2.0f;
        // Debug.Log((directionToTarget0 + directionToTarget1) / 2.0f);
        // Debug.Log(directionToTarget0);
        // Debug.Log(directionToTarget1);
        
        midPoint.Translate((directionToTarget0 + directionToTarget1) / 2.0f);
    }

    void midPointRotate()
    {
        midPoint.Rotate(Vector3.up * Time.deltaTime, Space.World);
    }
}
