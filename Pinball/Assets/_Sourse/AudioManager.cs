using UnityEngine.Audio;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    void Awake()
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.sourse = gameObject.AddComponent<AudioSource>();
            s.sourse.clip = s.clip;

            s.sourse.volume = s.volume;
            s.sourse.pitch = s.pitch;
            s.sourse.loop = s.loop;
            s.sourse.outputAudioMixerGroup = s.group;
        }
    }

    void Start()
    {
    }

    public void Play(string name)
    {

        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.sourse.Play();
    }
}