using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;
    
    private void Update()
    {
        transform.localScale += Vector3.one * _growthSpeed * Time.deltaTime;
    }
}
