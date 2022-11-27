using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Balloon : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private float _timeOfLife;
    [SerializeField] private ParticleSystem _effectOfDeath;

    private Rigidbody2D _rigidbody2D;
    private float _nowTimeOfLife;

    private void OnEnable()
    {
        _nowTimeOfLife = _timeOfLife;
    }

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (_nowTimeOfLife <= 0)
        {
            _effectOfDeath.gameObject.transform.position = transform.position;
            _effectOfDeath.Play();
            gameObject.SetActive(false);
        }

        _nowTimeOfLife -= Time.deltaTime;
        _rigidbody2D.velocity = Vector2.up * _speed;
    }
}
