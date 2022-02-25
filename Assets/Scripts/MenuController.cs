using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class MenuController : MonoBehaviour
{
    public GameObject mainmenu, optionsmenu, howtoplaymenu;
    public GameObject easydiff, normaldiff, harddiff;
    public GameObject musicon, musicoff;
    public GameObject am;
    public Button playgame, diffeasy;
    [SerializeField] Slider music;
    // Start is called before the first frame update
    void Start()
    {
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(playgame.gameObject, new BaseEventData(eventSystem));
    }

    public void PlayClick()
    {
        am.GetComponent<AudioManager>().PlaySFX("click");
    }
    public void MainMenu()
    {
        PlayClick();
        optionsmenu.SetActive(false);
        howtoplaymenu.SetActive(false);
        mainmenu.SetActive(true);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(playgame.gameObject, new BaseEventData(eventSystem));
    }
    public void Game()
    {
        PlayClick();
        SceneManager.LoadScene("Game");
    }
    public void Options()
    {
        PlayClick();
        optionsmenu.SetActive(true);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(diffeasy.gameObject, new BaseEventData(eventSystem));
        diffeasy.Select();
        mainmenu.SetActive(false);
    }
    public void HowToPlay()
    {
        PlayClick();
        howtoplaymenu.SetActive(true);
        mainmenu.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ChangeToEasy()
    {
        PlayClick();
        easydiff.SetActive(true);
        normaldiff.SetActive(false);
        harddiff.SetActive(false);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(easydiff, new BaseEventData(eventSystem));
    }
    public void ChangeToNormal()
    {
        PlayClick();
        easydiff.SetActive(false);
        normaldiff.SetActive(true);
        harddiff.SetActive(false);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(normaldiff, new BaseEventData(eventSystem));
    }
    public void ChangeToHard()
    {
        PlayClick();
        easydiff.SetActive(false);
        normaldiff.SetActive(false);
        harddiff.SetActive(true);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(harddiff, new BaseEventData(eventSystem));
    }
    public void TurnMusicOn()
    {
        PlayClick();
        musicon.SetActive(true);
        musicoff.SetActive(false);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(musicon, new BaseEventData(eventSystem));
        music.value = 0.1f;
        PlayerPrefs.SetFloat("vol", 0.1f);
    }
    public void TurnMusicOff()
    {
        PlayClick();
        musicon.SetActive(false);
        musicoff.SetActive(true);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(musicoff, new BaseEventData(eventSystem));
    }
}
