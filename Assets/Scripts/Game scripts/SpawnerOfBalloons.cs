using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerOfBalloons : ObjectPool
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform[] _spawnsPoints;

    private int _numberOfSpawnPoint;
    private float _timeForSpawn = 1.2f;
    private float _nowTime;

    private void Start()
    {
        Initialize(_prefab);
    }

    private void Update()
    {
        _nowTime += Time.deltaTime;

        if (_timeForSpawn <= _nowTime)
        {
            if (TryGetObject(out GameObject balloon))
            {
                _nowTime = 0;
                _numberOfSpawnPoint = Random.Range(0, _spawnsPoints.Length);
                balloon.SetActive(true);
                balloon.transform.position = _spawnsPoints[_numberOfSpawnPoint].position;
            }
        }
    }
}
