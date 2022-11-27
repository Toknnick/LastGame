using UnityEngine;

public class TeleporterInBlackHole : MonoBehaviour
{
    [SerializeField] private Transform _teleportPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = new Vector2(_teleportPosition.position.x, _teleportPosition.position.y);
    }
}
