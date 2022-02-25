using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bgmusic : MonoBehaviour
{
    public AudioSource puzzleMusic;
    [SerializeField] Slider music;
    public GameObject musicon, musicoff;
    int musickey;
    float musicplay;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("musickey"))
		{
            Debug.Log("Music has been defaultly set to 1");
			PlayerPrefs.SetFloat("musickey", 1);
            musicon.SetActive(true);
            musicoff.SetActive(false);
		}
		else
		{
			musicplay = PlayerPrefs.GetFloat("musickey");
            if(musicplay != 1) 
            {
                Debug.Log("Music is currently inactive.");
                musicon.SetActive(false);
                musicoff.SetActive(true);
            }
            else{
                Debug.Log("Music is currently active.");
                musicon.SetActive(true);
                musicoff.SetActive(false);
            }
		}
    }

    // Update is called once per frame
    void Update()
    {
        if (musicon.activeSelf) 
        {
            Debug.Log("Music is currently active.");
            puzzleMusic.volume = music.value;
            musicon.SetActive(true);
            musicoff.SetActive(false);
        }
        else
        {   
            Debug.Log("Music is currently inactive.");
            puzzleMusic.volume = 0;
            if(PlayerPrefs.GetFloat("musickey") != 1)
            {
                PlayerPrefs.SetFloat("musickey", 0);
                musicon.SetActive(false);
                musicoff.SetActive(true);
            }
        }
    }
}
