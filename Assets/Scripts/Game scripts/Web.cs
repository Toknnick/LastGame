using UnityEngine;

public class Web : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private Transform _triggerTransform;
    [SerializeField] private Rigidbody2D _playerRigidbody2D;

    private bool _isKeepPlayer = false;
    private float _defaultGravityScale = 2;
    private float _speed = 0.5f;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _triggerTransform.position, _speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            _playerController.transform.SetParent(transform);
            _playerController.ChangeGravityScale(0);
            _playerRigidbody2D.velocity = Vector2.zero;
            _playerController.enabled = false;
            _isKeepPlayer = true;
        }
        else 
        {
            if (_isKeepPlayer)
            {
                _playerController.ChangeGravityScale(_defaultGravityScale);
                _playerController.transform.SetParent(null);                
                _isKeepPlayer = false;
                _playerController.enabled = true;
            }

            gameObject.SetActive(false);
        }
    }
}
