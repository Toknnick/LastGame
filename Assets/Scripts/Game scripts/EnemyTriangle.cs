using UnityEngine;
public class EnemyTriangle : MonoBehaviour
{
    [SerializeField] private int _speed = 5;
    [Header("-1 = left, 1 = right")]  
    [SerializeField] private int _movingSide = -1;
    [SerializeField] private GameObject _fakeTriangle;

    [Space(10)]
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    public void SwitchState(bool isTurnOn)
    {
        if (isTurnOn == false)
        {
            enabled = false; 
            _animator.enabled = false;
            _rigidbody2D.Sleep();
            _spriteRenderer.enabled = false;
            _fakeTriangle.SetActive(true);
        }
        else
        {
            enabled = true;
            _animator.enabled = true;
            _rigidbody2D.WakeUp();
            _spriteRenderer.enabled = true;
            _fakeTriangle.SetActive(false);
        }

    }

    public void RotateMoving()
    {
        if (_movingSide == 1)
            _movingSide = -1;
        else
            _movingSide = 1;
    }

    void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(_movingSide * _speed, _rigidbody2D.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
            SwitchState(false);
    }
}
