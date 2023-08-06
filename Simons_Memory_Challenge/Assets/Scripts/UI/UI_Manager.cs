using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager Instance;
    public GameScreen_UI Game_Screen;

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

    public void setGameScreen()
    {
        Game_Screen.EnableScreen();
        Game_Screen.set_LevelNo(GameData.Instance.Level_No);
        Game_Screen.set_Score(GameData.Instance.Score);
    }



}
