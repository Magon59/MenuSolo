using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    public TMPro.TextMeshProUGUI TextValue;
    public Slider Slider;
    public AudioSource Music;


    public void OnvalueChanged(float newValue)
    {
        OnMusicValueChanged(newValue);
        int valueInt = (int)Mathf.Round(newValue * 100.0f);
        TextValue.text = valueInt.ToString();

    }

    public void OnMusicValueChanged(float newValue)
    {
        Music.volume = newValue;
    }

}
