using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FallingBlock : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_rigidbody2D.isKinematic == false && collision.gameObject.TryGetComponent(out Player player) == false && collision.gameObject.TryGetComponent(out Ground ground) == false)
            gameObject.SetActive(false);
        else
            _rigidbody2D.isKinematic = false;
    }
}
