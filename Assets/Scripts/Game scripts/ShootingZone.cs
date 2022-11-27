using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingZone : MonoBehaviour
{
    [SerializeField] private ShootingBlock[] _shootingblocks;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
            foreach (var shottingBlock in _shootingblocks)
            shottingBlock.Shoot();
    }
}
