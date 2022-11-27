using UnityEngine;

public class Connector : MonoBehaviour
{
    [SerializeField] private GameObject _first;
    [SerializeField] private GameObject _second;
    [SerializeField] private GameObject _mainMirror;
    [SerializeField] private Camera _camera;
    [SerializeField] private float _positionForCamera;

    private bool _stateForFirstHalfOfPlayer = false;
    private bool _stateForSecondHalfOfPlayer = false;

    public void SetStateForFirstHalfOfPlayer(bool value)
    {
        _stateForFirstHalfOfPlayer = value;
    }

    public void SetStateForSecondHalfOfPlayer(bool value)
    {
        _stateForSecondHalfOfPlayer = value;
    }

    private void Update()
    {
        if (_stateForFirstHalfOfPlayer && _stateForSecondHalfOfPlayer && _first.GetComponent<Player>().IsTeleportedNow == false && _second.GetComponent<Player>().IsTeleportedNow == false)
        {
            _second.SetActive(false);
            _first.GetComponent<Player>().SetBoolIsTeleportedNow(true);
            _first.transform.position = _mainMirror.transform.position;
            _camera.transform.position = new Vector3(_camera.transform.position.x, _camera.transform.position.y + _positionForCamera, _camera.transform.position.z);
            _stateForFirstHalfOfPlayer = false;
            _stateForSecondHalfOfPlayer = false;
        }
    }
}
