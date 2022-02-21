using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{
    public void QualityGame(int param)
    {
        QualitySettings.SetQualityLevel(param);
    }
}
