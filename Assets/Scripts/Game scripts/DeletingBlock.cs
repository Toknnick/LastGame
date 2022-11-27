using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletingBlock : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(TurnOf());
    }

    private IEnumerator TurnOf()
    {
        yield return new WaitForSeconds(0.85f);
        gameObject.SetActive(false);
    }
}
