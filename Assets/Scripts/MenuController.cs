using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{
    public GameObject mainmenu, optionsmenu, howtoplaymenu;
    public GameObject easydiff, normaldiff, harddiff;
    public GameObject musicon, musicoff;
    public GameObject am;
    public Button playgame, diffeasy;
    // Start is called before the first frame update
    void Start()
    {
        playgame = GetComponent<Button>();
        playgame.Select();
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
        playgame = GetComponent<Button>();
        playgame.Select();
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
        diffeasy = GetComponent<Button>();
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
    }
    public void ChangeToNormal()
    {
        PlayClick();
        easydiff.SetActive(false);
        normaldiff.SetActive(true);
        harddiff.SetActive(false);
    }
    public void ChangeToHard()
    {
        PlayClick();
        easydiff.SetActive(false);
        normaldiff.SetActive(false);
        harddiff.SetActive(true);
    }
    public void TurnMusicOn()
    {
        PlayClick();
        musicon.SetActive(true);
        musicoff.SetActive(false);
    }
    public void TurnMusicOff()
    {
        PlayClick();
        musicon.SetActive(false);
        musicoff.SetActive(true);
    }
}
