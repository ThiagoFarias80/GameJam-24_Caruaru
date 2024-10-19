using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;


public class StartMenuController : MonoBehaviour
{
    private FadeController Fade;
    public Button _btnPlay;
    public Button _btnCredits;
    private object instance;

    private void Awake()
    {
        Fade = FindAnyObjectByType<FadeController>();
        _btnCredits.onClick.AddListener(Credits);
        _btnPlay.onClick.AddListener(Play);
    }

    private void Start()
    {
        Fade.FadeIn(1, null, 0);
    }
        
    private void Play()
    {
        Fade.FadeOut(1, () => { UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay"); }, 0);
        _btnCredits.interactable = false;
        _btnPlay.interactable = false;

    }

    public void Credits()
    {
        _btnCredits.interactable = false;
        _btnPlay.interactable = false;

    }

    private void ActiveButtons()
    {
        _btnCredits.interactable = true;
        _btnPlay.interactable = true;
    }
}
