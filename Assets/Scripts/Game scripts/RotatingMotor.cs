using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingMotor : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Rotate(new Vector3(transform.rotation.x,transform.rotation.y,_speed));
    }
}
