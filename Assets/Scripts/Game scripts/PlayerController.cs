using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private GroundSensor _groundSensor;
    [SerializeField] private Animator _animator;
    [SerializeField] private Joystick _joystick;

    private bool _isGrounded;
    private bool _isInLadderZone;
    private float _horizontalMove;
    private float _verticalMove;

    public void ChangeJumpForce(float value)
    {
        _jumpForce = value;
    }

    public void ChangeGravityScale(float value)
    {
        _rigidbody2D.gravityScale = value;
    }

    private void Update()
    {
        if (_isGrounded == false && _groundSensor.IsGrounded)
            _isGrounded = true;
        else if (_isGrounded == true && _groundSensor.IsGrounded == false)
            _isGrounded = false;

        if (_isGrounded == true && Mathf.Abs(_horizontalMove) < Mathf.Epsilon)
            _animator.SetBool("Idle", true);
        else if (_isGrounded == false || Mathf.Abs(_horizontalMove) > Mathf.Epsilon)
            _animator.SetBool("Idle", false);
    }

    private void FixedUpdate()
    {
        _horizontalMove = _joystick.Horizontal;
        _verticalMove = _joystick.Vertical;

        if (_isGrounded == true && _verticalMove >= .5f || _isInLadderZone == true && _verticalMove >= .5f)
            _rigidbody2D.velocity = Vector2.up * _jumpForce;
        else if (_verticalMove == 0 && _isInLadderZone == true)
            _rigidbody2D.velocity = Vector2.zero;
        else if (_isGrounded == false && _verticalMove <= .5f && _isInLadderZone == true)
            _rigidbody2D.velocity = Vector2.down * _jumpForce;

        _rigidbody2D.velocity = new Vector2(_horizontalMove * _speed, _rigidbody2D.velocity.y);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out LadderZone ladderZone))
        {
            _rigidbody2D.gravityScale = 0;
            _isInLadderZone = true;
            _isGrounded = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out LadderZone ladderZone))
        {
            _rigidbody2D.gravityScale = 2;
            _isInLadderZone = false;
            _isGrounded = true;
        }
    }
}
