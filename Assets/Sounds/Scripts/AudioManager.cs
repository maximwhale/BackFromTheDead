using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

	public static AudioManager instance;

	public AudioMixerGroup mixerGroup;

	public Sound[] sounds;

	void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}

		foreach (Sound s in sounds)
		{
			s.sources = new AudioSource[s.n_sources];
			for (int i = 0; i < s.n_sources; i++) {
				s.sources[i] = gameObject.AddComponent<AudioSource>();
				s.sources[i].clip = s.clip;
				s.sources[i].loop = s.loop;
				s.sources[i].volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
				s.sources[i].pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));
				s.sources[i].outputAudioMixerGroup = mixerGroup;
			}
		}
	}

	public void Play(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogError("Sound: " + name + " not found!");
			return;
		}
		for (int i = 0; i < s.n_sources; i++)
		{
			if (!s.sources[i].isPlaying)
			{
				s.sources[i].Play();
				break;
			}
		}
	}

}
