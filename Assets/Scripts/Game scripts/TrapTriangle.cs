using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTriangle : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;

    public void TurnOnDynamicRigidbody2D()
    {
        _rigidbody2D.isKinematic = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Trap trap) == false)
            gameObject.SetActive(false);
    }
}
