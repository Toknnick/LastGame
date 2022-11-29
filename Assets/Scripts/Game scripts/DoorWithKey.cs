using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class DoorWithKey : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Sprite _openedLockSprite;
    [SerializeField] private SpriteRenderer _spriteRendererOfLock;

    private bool _isOpening = false;
    private BoxCollider2D _boxCollider2D;

    private void Start()
    {   
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
            _isOpening = player.TryOpenDoorWithKey();

        if (_isOpening == true)
        {
            _audioSource.Play();
            _spriteRendererOfLock.sprite = _openedLockSprite;
            _boxCollider2D.isTrigger = true;
        }
    }
}
