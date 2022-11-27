using UnityEngine;

public class UppingDoor : MonoBehaviour
{
    [SerializeField] private int _speed = 3;
    [SerializeField] private int _positionAfterOpen = 2;

    private bool _isOpening = false;
    private bool _isClosing = false;
    private bool _isMove = true;
    private Vector2 _startPosition;

    public void Open()
    {
        _isOpening = true;
        _isClosing = false;
    }

    public void Close()
    {
        _isOpening = false;
        _isClosing = true;
    }

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        if (_isMove)
        {
            if (_isOpening)
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(_startPosition.x, _startPosition.y + _positionAfterOpen), Time.deltaTime * _speed);
            else if (_isClosing)
                transform.position = Vector2.MoveTowards(transform.position, _startPosition, Time.deltaTime * _speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
            _isMove = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
            _isMove = true;
    }
}
