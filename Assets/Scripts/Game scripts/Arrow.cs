using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Vector2 _direction;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private int _speed = 6;

    private void Start()
    {
            transform.rotation = Quaternion.Euler(_rotation.x, _rotation.y, _rotation.z);
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = _direction * _speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out ShootingBlock shootingBlock) == false)
            Destroy(gameObject);
    }
}
