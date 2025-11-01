using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthInSize : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;
    void Update()
    {
        transform.localScale += Vector3.one * (_growthSpeed * Time.deltaTime);
        transform.localScale += Vector3.up * (_growthSpeed * Time.deltaTime);
        transform.localScale += Vector3.down * (_growthSpeed * Time.deltaTime);
    }
}
