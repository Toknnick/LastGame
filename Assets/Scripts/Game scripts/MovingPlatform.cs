using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float _speed;
    [Header("-1 = left, 1 = right")]
    [SerializeField] private int _movingSide = -1;

    public void ChangeDirection()
    {
        _movingSide *= -1;
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x + _movingSide * _speed * Time.deltaTime, transform.position.y);
    }
}
