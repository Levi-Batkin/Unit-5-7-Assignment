using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
	public Sound[] sounds;
	[SerializeField] Slider music, sfx;
	public static float vol;
	AudioSource audioSource;
	public static float volume;
	
	void Awake()
	{
		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.volume = music.value;
			s.source.clip = s.clip;
			s.source.pitch = 1;
		}
	}
	public void Start()
	{
		if(!PlayerPrefs.HasKey("vol"))
		{
			PlayerPrefs.SetFloat("vol", 1);
		}
		else
		{
			music.value = PlayerPrefs.GetFloat("vol");
			print("get music float");
		}

		if(!PlayerPrefs.HasKey("sfx"))
		{
			PlayerPrefs.SetFloat("sfx", 1);
		}
		else
		{
			sfx.value = PlayerPrefs.GetFloat("sfx");
			print("get sfx float");

		}
	}
	
	public void SaveMusic()
	{
		print("music value " + music.value);
		PlayerPrefs.SetFloat("vol", music.value);
	}

	public void SaveSFX()
	{
		print("sfx value " + sfx.value);
		PlayerPrefs.SetFloat("sfx", sfx.value);
	}

	public void Play(string name)
	{
		Debug.Log("Playing audio.");
		Sound s = Array.Find(sounds, sound => sound.name == name);
		if (s == null)
		{
			Debug.Log("Cannot find "+name);
		} 
		s.source.volume = PlayerPrefs.GetFloat("vol", music.value);
		print("music value " + music.value);
		s.source.Play();
	}
	public void PlaySFX(string name)
	{
		Debug.Log("Playing audio.");
		Sound s = Array.Find(sounds, sound => sound.name == name);
		if (s == null)
		{
			Debug.Log("Cannot find "+name);
		}
		s.source.volume = PlayerPrefs.GetFloat("sfx", sfx.value);
		print("sfx value " + sfx.value);
		s.source.Play();
	}
	public void Stop(string name)
	{
		Sound s = Array.Find(sounds, sound => sound.name == name);
		if (s == null)
		{
			Debug.Log("Cannot find "+name);
		}
		s.source.Stop();
	}
}

