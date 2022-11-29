using System;
using UnityEngine;

public class TrapTriangle : MonoBehaviour
{
    public Action OnPressedOnButton;
    [SerializeField] private Rigidbody2D _rigidbody2D;

    public void TurnOnDynamicRigidbody2D()
    {
        _rigidbody2D.isKinematic = false;
    }

    private void OnEnable()
    {
        OnPressedOnButton += TurnOnDynamicRigidbody2D;
    }

    private void OnDisable()
    {
        OnPressedOnButton -= TurnOnDynamicRigidbody2D;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Trap trap) == false)
            gameObject.SetActive(false);
    }
}
