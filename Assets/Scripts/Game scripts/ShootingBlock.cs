using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBlock : MonoBehaviour
{
    [SerializeField] private GameObject _arrow;
    [SerializeField] Transform _sootPoint;

    public void Shoot()
    {
        Instantiate(_arrow, new Vector2(_sootPoint.position.x, _sootPoint.position.y), Quaternion.identity);
    }
}
