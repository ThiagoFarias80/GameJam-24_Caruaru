using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanMoveController : MonoBehaviour
{ 
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position -= Vector3.forward * Time.deltaTime * _speed;
    }
}
