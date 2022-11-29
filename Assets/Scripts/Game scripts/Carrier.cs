using System.Collections;
using UnityEngine;

public class Carrier : ObjectPool
{

    [SerializeField] private GameObject _web;
    [SerializeField] private Transform _spawnPoint;

    private WaitForSeconds _timer  = new WaitForSeconds(1);

    private void Start()
    {
        Initialize(_web);
    }

    private void OnEnable()
    {
        StartCoroutine(Spawn());
    }

    private void OnDisable()
    {
        StopCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            if (TryGetObject(out GameObject web))
            {
                web.SetActive(true);
                web.transform.position = _spawnPoint.position;
            }

            yield return _timer;
        }
    }
}
