using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemusic : MonoBehaviour
{
    public AudioSource gameSource;
    public AudioSource soundEffect;
    public AudioClip click;
    // Start is called before the first frame update
    void Start()
    {
    }
    public void PlayClick()
    {
        soundEffect.PlayOneShot(click, PlayerPrefs.GetFloat("vol"));
    }
    // Update is called once per frame
    void Update()
    {
        gameSource.volume = PlayerPrefs.GetFloat("vol");
        soundEffect.volume = PlayerPrefs.GetFloat("sfx");
        Debug.Log("Music Volume:" + PlayerPrefs.GetFloat("vol"));
        Debug.Log("SFX Volume:" + PlayerPrefs.GetFloat("sfx"));
    }
}
