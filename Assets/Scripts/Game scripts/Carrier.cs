using UnityEngine;

public class Carrier : ObjectPool
{

    [SerializeField] private GameObject _web;
    [SerializeField] private Transform _spawnPoint;

    private float _timeForSpawn = 1;
    private float _nowTimeForSpawnWeb;

    private void Start()
    {
        Initialize(_web);
    }

    private void Update()
    {
        _nowTimeForSpawnWeb += Time.deltaTime;

        if (_timeForSpawn <= _nowTimeForSpawnWeb)
        {
            if (TryGetObject(out GameObject web))
            {
                _nowTimeForSpawnWeb = 0;
                web.SetActive(true);
                web.transform.position = _spawnPoint.position;
            }
        }
    }
}
