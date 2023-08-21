using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager Instance;
    public GameScreen_UI Game_Screen;
    public ToySelection ToySelection_Screen;
    public HomeScreen Home_Screen;
    public GameOver GameOver_Screen;

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
    private void Start()
    {
        //Set_ToyselectionScreen();
    }

    public void Set_ToyselectionScreen()
    {
        ToySelection_Screen.EnableScreen();
        ToySelection_Screen.PopulateToyTiles(5);
    }

    public void setGameScreen()
    {
        Game_Screen.ActivateScreen();
    }

    public void OnToySelected( int Toy_Id)
    {
        Debug.Log("UI_Mgr OnToySelected : " + Toy_Id);
        GameData.Instance.Toy_Id = Toy_Id;
        setGameScreen();
        ToySelection_Screen.DisableScreen();

    }

    public void SetHomeScreen()
    {
        Home_Screen.EnableScreen();
    }

    public void Set_GameOver_Screen()
    {
        GameOver_Screen.EnableScreen();
    }





}
