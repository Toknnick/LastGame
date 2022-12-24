using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Sprite _unLockedIcon;
    [SerializeField] private Sprite _lockedIcon;
    [SerializeField] private int _minNumberOfLevel;

    private void Start()
    {
        Transform child;

        for (int i = 0; i < transform.childCount; i++)
        {
            child = transform.GetChild(i);
            child.name = _minNumberOfLevel.ToString();

            if (_minNumberOfLevel <= SaverParametrs.CountOfOpenLevels)
            {
                child.GetComponent<Image>().sprite = _unLockedIcon;
                child.GetComponent<Button>().interactable = true;
            }
            else
            {
                child.GetComponent<Image>().sprite = _lockedIcon;
                child.GetComponent<Button>().interactable = false;
            }

            _minNumberOfLevel += 1;
        }
    }
}
