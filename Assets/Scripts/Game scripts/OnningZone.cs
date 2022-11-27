using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnningZone : MonoBehaviour
{
    [SerializeField] private GameObject[] _objects;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
            foreach (var gameobject in _objects)
                gameobject.SetActive(true);
    }
}
