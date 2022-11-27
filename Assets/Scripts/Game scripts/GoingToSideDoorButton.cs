using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingToSideDoorButton : MonoBehaviour
{
    [SerializeField] private GoingToSideDoor _door;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _door.Open();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        _door.Open();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _door.Close();
    }
}
