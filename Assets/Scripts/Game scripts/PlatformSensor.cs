using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSensor : MonoBehaviour
{
    [SerializeField] private MovingPlatform _plaform;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Ground ground))
            _plaform.ChangeDirection();
    }
}
