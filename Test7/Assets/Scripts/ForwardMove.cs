using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMove : MonoBehaviour
{
    private void Update()
    {
        float maxDistant = 3.0f;
        float minDistant = -3.0f;
        var nextPosition = transform.position;
        
        if(nextPosition.x == maxDistant)
        {
            nextPosition.x = minDistant;
            transform.position = nextPosition;
        }
        else
        {
            nextPosition.x += 0.01f;
            transform.position = nextPosition;
        }
    }
}
