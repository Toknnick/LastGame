using UnityEngine;

public class MainMirror : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Transform _positionForFirst;
    [SerializeField] private Transform _positionForSecond;
    [SerializeField] private GameObject _second;
    [SerializeField] private Camera _camera;
    [SerializeField] private float _positionForCamera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            if (player.IsTeleportedNow == false)
            {
                _audioSource.Play();
                _second.SetActive(true);
                _second.GetComponent<Player>().SetBoolIsTeleportedNow(true);
                player.SetBoolIsTeleportedNow(true);
                player.transform.position = _positionForFirst.position;
                _second.transform.position = _positionForSecond.position;
                _camera.transform.position = new Vector3(_camera.transform.position.x, _camera.transform.position.y - _positionForCamera, _camera.transform.position.z);
            }
            else
            {
                _second.SetActive(false);
                _second.GetComponent<Player>().SetBoolIsTeleportedNow(false);

            }
        }
    }
}
