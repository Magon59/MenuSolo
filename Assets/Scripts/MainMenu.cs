using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Image ImageFade;
    public List<MainMenuButton> Buttons;
    public GameObject Menu;
    public GameObject MenuStart;
    public GameObject MenuOption;
    public GameObject MenuSocial;

    public Image ImageSplash;
    public AudioSource OST;
    public AudioSource SoundSelect;
    public GameObject[] Pages;
    int index = 0;
    List <int> previousIndex = new List<int>();
    

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && index == 0)
        {
            clicIndex(1);
            SoundSelect.Play();
            ImageSplash.DOFade(0, 0.5f).OnComplete(FadeSplash);

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log("piou");
            BackPages();
        }
    }
    public void OnClickPlay()
    {
        OST.DOFade(0, 0.3f);
        //Debug.Log("ok 1");

        for (int i = 1; i < Buttons.Count; i++)
        {
            Buttons[i].Hide(0.1f);
        }

        ImageFade.DOFade(1, 6.5f).OnComplete(FadeComplete);

        //Debug.Log("ok 2");

    }

    public void OnClickOptions()
    {

        Menu.SetActive(false);
        MenuOption.SetActive(true);

    }
    public void OnClickSocial()
    {

        Menu.SetActive(false);
        MenuSocial.SetActive(true);

    }

    public void OnClickQuit()
    {
        Application.Quit();
        Debug.Log("Bily est mort");

    }

    private void FadeComplete()
    {
        SceneManager.LoadScene("Gameplay");
    }

    private void FadeSplash()
    {
        MenuStart.SetActive(false);
        Menu.SetActive(true);
        ImageSplash.DOFade(1, 0f); // on remet l'alpha a 1 pour qu'au retour l'image apparaissent
    }

    public void BackPages()
    {
        if (index == 0)
        {
            return;
        }
        Pages[index].SetActive(false); // on desactive la page active
        index = previousIndex[previousIndex.Count - 1];
        previousIndex.RemoveAt(previousIndex.Count - 1);
        Pages[index].SetActive(true); // tu active la page precedente
    }

    public void clicIndex(int idx) // l'index = celui de la page sur lequelle on clic // ex: 8
    {
        previousIndex.Add(index); // on ajoute l'index actuelle a previousIndex // ex : 4
        Pages[index].SetActive(false); // on desactive la page actuelle // ex : 4
        index = idx; //l'index actuelle devient celui qu'on a clic // ex : 8
        Pages[index].SetActive(true); // on affiche la page de l'index idx  //ex : 8

    }

   
    
}
