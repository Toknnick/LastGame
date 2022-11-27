using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static int CountOfOpenLevels = 1;

    [SerializeField] private Sprite _unLockedIcon;
    [SerializeField] private Sprite _lockedIcon;
    [SerializeField] private int _minNumberOfLevel;

    private void Start()
    {
        if (CountOfOpenLevels > 1)
            CountOfOpenLevels = PlayerPrefs.GetInt("CountOfOpenLevels");

        Transform child;

        for (int i = 0; i < transform.childCount; i++)
        {
            child = transform.GetChild(i);
            child.name = _minNumberOfLevel.ToString();

            if (_minNumberOfLevel <= CountOfOpenLevels)
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
