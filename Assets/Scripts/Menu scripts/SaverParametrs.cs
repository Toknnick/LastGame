using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaverParametrs : MonoBehaviour
{
    public static int CountOfOpenLevels = 1;
    
    private void OnEnable()
    {
        if (PlayerPrefs.GetInt("CountOfOpenLevels") != 0)
            CountOfOpenLevels = PlayerPrefs.GetInt("CountOfOpenLevels");
    }
}
