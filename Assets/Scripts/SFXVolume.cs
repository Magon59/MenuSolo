using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SFXVolume : MonoBehaviour
{
    public TMPro.TextMeshProUGUI Text;
    private int value = 100;
    public int valueMax = 100;
    public int valueMin = 0;
    public AudioSource SwipeSFX;
    public AudioSource PlaySFX;
    public AudioSource SpacebarSFX;

    public void OnClickNext()
    {
        if (value < valueMax)
        {
            value += 5;
            UpdateAffichage();
        }
    }

    public void UpdateAffichage()
    {
        Text.text = "" + value;
        SwipeSFX.volume = value / 100f;
        PlaySFX.volume = value / 100f;
        SpacebarSFX.volume = value / 100f;

    }


    public void OnClickPrevious()
    {
        if (value > valueMin)
        {
            value -= 5;
            UpdateAffichage();
        }
    }
}
