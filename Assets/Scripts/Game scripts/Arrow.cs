using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private int _speed = 10;
    [SerializeField] private bool _isRight;
    [SerializeField] private bool _isUp;
    [SerializeField] private bool _isMovingOnXDirection;
    [SerializeField] private bool _isMovingOnYDirection;

    private void Start()
    {
        if (_isMovingOnYDirection && _isUp)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);
        }
        else if (_isMovingOnYDirection && _isUp == false)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -90);
        }
        else if (_isMovingOnXDirection && _isRight == false)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -180);
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.15f);
        }
    }

    void Update()
    {
        if (_isMovingOnXDirection && _isRight)
            _rigidbody2D.velocity = new Vector2(_speed, _rigidbody2D.velocity.y);
        else if (_isMovingOnXDirection && _isRight == false)
            _rigidbody2D.velocity = new Vector2(-_speed, _rigidbody2D.velocity.y);
        else if (_isMovingOnYDirection && _isUp)
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, _speed);
        else if (_isMovingOnYDirection && _isUp == false)
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, -_speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out ShootingBlock shootingBlock) == false)
            Destroy(gameObject);
    }
}
