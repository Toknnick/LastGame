using UnityEngine;

public class MirrorForSecondHalfOfPlayer : MonoBehaviour
{
    [SerializeField] private Connector _connector;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
            if (player.IsTeleportedNow == false)
                _connector.SetStateForSecondHalfOfPlayer(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
            if (player.IsTeleportedNow == false)
                _connector.SetStateForSecondHalfOfPlayer(false);
    }
}

