using UnityEngine;

public class OpenerNextLevelPanel : MonoBehaviour
{
    [SerializeField] private GameObject _panelStaringWith1;
    [SerializeField] private GameObject _panelStaringWith16;

    public void OpenNewLevelPanel()
    {
        if (_panelStaringWith1.activeSelf == true)
        {
            _panelStaringWith1.SetActive(false);
            _panelStaringWith16.SetActive(true);
        }
        else
        {
            _panelStaringWith1.SetActive(true);
            _panelStaringWith16.SetActive(false);
        }
    }
}
