using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAroundAxis : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
    private void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, _rotateSpeed * Time.deltaTime);
    }
}
