using UnityEngine;
using UnityEngine.UI;

public class ChangerSizeOfPlayer : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private GameObject _player;
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private GameObject _effectOfPlayer;
    [SerializeField] private Camera _camera;

    public void ChangeSize()
    {
        _player.transform.localScale = new Vector3(_slider.value, _slider.value, _slider.value);
        _effectOfPlayer.transform.localScale = new Vector3(_slider.value, _slider.value, _slider.value);
        _playerController.ChangeJumpForce(_slider.value * 10);
        _playerController.ChangeGravityScale(_slider.value * 2);
        _camera.orthographicSize = _slider.value + 4;
    }
}
