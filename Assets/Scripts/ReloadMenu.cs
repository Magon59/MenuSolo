using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadMenu : MonoBehaviour

{
    public Image ImageFade;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            ImageFade.DOFade(1, 3f).OnComplete(FadeComplete);
            
        }

    }

    public void FadeComplete()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
