using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject pausebutton;
    public GameObject pausemenu;
    int controller = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            controller = controller + 1;
            pausebutton.SetActive(false);
            pausemenu.SetActive(true);
            Debug.Log("Escape key was pressed");
        }

    }
    public void BackToGame()
    {
        pausebutton.SetActive(true);
        pausemenu.SetActive(false);
    }
    public void PauseGame()
    {
        pausebutton.SetActive(false);
        pausemenu.SetActive(true);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
