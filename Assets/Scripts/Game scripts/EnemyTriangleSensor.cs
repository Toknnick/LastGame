using UnityEngine;

public class EnemyTriangleSensor : MonoBehaviour
{
    [SerializeField] private EnemyTriangle _body;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Ground ground))
            _body.RotateMoving();
    }
}
