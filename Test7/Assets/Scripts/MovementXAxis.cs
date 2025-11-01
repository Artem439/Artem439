using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementXAxis : MonoBehaviour
{
    private void Update()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.x += 0.01f;
        transform.position = nextPosition;
    }
}