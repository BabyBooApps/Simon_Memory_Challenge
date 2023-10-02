using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioSource ShortSounds_Player;

    public AudioClip Button_Click;
    public AudioClip LevelSuccess;
    public AudioClip LevelFail;
   
    private void Awake()
    {
        // Ensure that only one instance of the class exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional: Prevent the object from being destroyed when loading new scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances of the singleton class
        }
    }

    public void PlayShortSound(AudioClip clip)
    {
        ShortSounds_Player.Stop();
        ShortSounds_Player.clip = clip;
        ShortSounds_Player.Play();
    }


}
