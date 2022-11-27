using UnityEngine;

public class MirrorForFirstHalfOfPlayer : MonoBehaviour
{
    [SerializeField] private Connector _connector;
    [SerializeField] private GameObject _secondHalfOfPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
            if (player.IsTeleportedNow == false)
                _connector.SetStateForFirstHalfOfPlayer(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
            if (player.IsTeleportedNow == false)
                _connector.SetStateForFirstHalfOfPlayer(true);
    }
}
