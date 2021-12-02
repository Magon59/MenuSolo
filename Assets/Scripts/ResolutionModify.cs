using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionModify : MonoBehaviour
{

    int idx = 0;

    public string[] values;
    public TMPro.TextMeshProUGUI Text;


    void Start()
    {
        UpdateValue();
    }

    public void UpdateValue()
    {
        Text.text = values[idx];
        if (idx == 0)
            Screen.SetResolution(1920, 1080, true);
        else if (idx == 1)
            Screen.SetResolution(1024, 768, true);
        else if (idx == 2)
            Screen.SetResolution(1280, 720, true);
    }

    public void OnClickMoins()
    {
        if (idx == 0)
        {
            // Si on veut pas boucler sur les valeurs, commenter cette ligne
            idx = values.Length - 1;
        }
        else
        {
            idx--;
        }
        UpdateValue();
    }

    public void OnClickPlus()
    {
        if (idx == values.Length - 1)
        {
            // Si on veut pas boucler sur les valeurs, commenter cette ligne
            idx = 0;
        }
        else
        {
            idx++;
        }
        UpdateValue();
    }

    //public void OnResolutionChanged(int newValue)
    //{
    //    if (newValue == 0)
    //        Screen.SetResolution(1920, 1080, false);
    //    else if (newValue == 1)
    //        Screen.SetResolution(1024, 768, false);
    //    else if (newValue == 2)
    //        Screen.SetResolution(1280, 720, false);

    //}


}
