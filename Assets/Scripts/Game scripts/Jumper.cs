using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Jumper : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private int _jumpForce;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Rigidbody2D rigidbody2D) && collision.gameObject.TryGetComponent(out Player player))
        {
            _audioSource.Play();
            _animator.SetBool("Jumped",true);
            rigidbody2D.AddForce(Vector2.up * _jumpForce);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _animator.SetBool("Jumped", false);
    }
}
