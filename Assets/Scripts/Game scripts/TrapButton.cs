using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapButton : MonoBehaviour
{
    [SerializeField] private TrapTriangle[] _trapTriangles;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (var trap in _trapTriangles)
            trap.TurnOnDynamicRigidbody2D();
    }
}
    