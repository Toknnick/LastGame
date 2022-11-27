using System.Collections;
using System.Collections.Generic;
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

    public void GetKey()
    {
        _countOfKeys++;
    }

    public void SetBoolIsTeleportedNow(bool value)
    {
        IsTeleportedNow = value;
    }

    public void SetNewSpawnPoint(Transform newSpawnPoint)
    {
        _spawnPoint = newSpawnPoint;
    }

    public void Die()
    {
        transform.position = _spawnPoint.position;
    }
}
