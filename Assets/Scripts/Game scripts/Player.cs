using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform _spawnPoint;
    private int _countOfKeys;

    public bool IsTeleportedNow { get; private set; }

    public bool TryOpenDoorWithKey()
    {
        bool result = false;

        if (_countOfKeys >= 1)
        {
            _countOfKeys--;
            result = true;
        }

        return result;
    }

    public void SetBoolIsTeleportedNow(bool value)
    {
        IsTeleportedNow = value;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Key key))
            _countOfKeys++;
        else if (collision.gameObject.TryGetComponent(out SetterNewSpawnPoint setterNewSpawnPoint))
            _spawnPoint = setterNewSpawnPoint.transform;
        else if(collision.gameObject.TryGetComponent(out DeathZone deathZone))
            transform.position = _spawnPoint.position;
    }
}
