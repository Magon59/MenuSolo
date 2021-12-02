using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionMusicVolume : MonoBehaviour
{
    public TMPro.TextMeshProUGUI Text;
    private int value = 100;
    public int valueMax = 100;
    public int valueMin = 0;
    public AudioSource MusicMainMenu;

    //public AudioMixer MixerSFX;

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
        MusicMainMenu.volume = value / 100f;
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
