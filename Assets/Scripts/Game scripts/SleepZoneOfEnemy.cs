using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepZoneOfEnemy : MonoBehaviour
{
    [SerializeField] private EnemyTriangle _bodyOfEnemyTriangle;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_bodyOfEnemyTriangle.enabled == true)
        {
            _bodyOfEnemyTriangle.OnSwitchedState(false);
            _bodyOfEnemyTriangle.enabled = false;
        }
    }
}
