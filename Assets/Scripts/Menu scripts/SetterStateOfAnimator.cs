using UnityEngine;

public class SetterStateOfAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void OnEnable()
    {
        _animator.SetBool("Idle", true);
    }
}
