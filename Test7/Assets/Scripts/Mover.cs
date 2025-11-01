using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private void Update()
    {
        float valueMovement = 0.01f;
        Vector3 nextPosition = transform.position;
        nextPosition.x += valueMovement;
        transform.position = nextPosition;
    }
}