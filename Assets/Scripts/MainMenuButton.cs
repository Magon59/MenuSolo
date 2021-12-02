using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour
{
    public Image ImageOutline;
    public TMPro.TextMeshProUGUI Text;
    public Color ColorInitial;
    public Color ColorSelected;

    public void OnPointerEnter()
    {
        if (_hidden)
            return;

        ImageOutline.DOKill(); // Supprimer le tween en cours si il y en a un
        ImageOutline.DOFade(1, 0.2f);

        Text.DOKill();
        Text.DOColor(ColorSelected, 0.2f);

        //Color color = ImageOutline.color;
        //color.a = 1;
        //ImageOutline.color = color;
    }

    public void OnPointerExit()
    {
        ImageOutline.DOKill(); // Supprimer le tween en cours si il y en a un
        ImageOutline.DOFade(0, 0.1f);

        Text.DOKill();
        Text.DOColor(ColorInitial, 0.2f);

        //Color color = ImageOutline.color;
        //color.a = 0;
        //ImageOutline.color = color;
    }

    public void Hide(float time)
    {
        ImageOutline.DOKill();
        ImageOutline.DOFade(0, time);

        Text.DOKill();
        Text.DOFade(0, time);

        _hidden = true;
    }

    bool _hidden = false;
}
