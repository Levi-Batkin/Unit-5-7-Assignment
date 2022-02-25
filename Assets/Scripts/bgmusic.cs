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
    }
    // Update is called once per frame
    void Update()
    {
        if (musicon.activeSelf) 
        {
            puzzleMusic.volume = music.value;
        }
        if (musicoff.activeSelf)
        {
            puzzleMusic.volume = 0;
            PlayerPrefs.SetFloat("vol", 0);
            music.value = PlayerPrefs.GetFloat("vol");
        }
    }
}
