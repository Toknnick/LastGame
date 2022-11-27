using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    private Vector3 _startPosition;

    public bool IsGrounded { get; private set; }

    private void Start()
    {
        _startPosition = transform.localPosition;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        ResetSensor();

        if (other.gameObject.TryGetComponent(out Ground ground) == true)
            IsGrounded = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground ground) == true)
            IsGrounded = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        ResetSensor();
        IsGrounded = false;
    }

    private void ResetSensor()
    {
        transform.localPosition = _startPosition;
    }
}
