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
    public QuitScreen quit_Screen;
    public ActiveScreen CurrentScreen;
    public ActiveScreen PreviousScreen;

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
        CurrentScreen = ActiveScreen.HomeScreen;
    }

    public void Set_ToyselectionScreen()
    {
        PreviousScreen = CurrentScreen;
        CurrentScreen = ActiveScreen.ToySelectionScreen;
        ToySelection_Screen.EnableScreen();
        ToySelection_Screen.PopulateToyTiles(GamePlay.Instance.ToyMgr.ToyList.Count);
    }

    public void setGameScreen()
    {
        PreviousScreen = CurrentScreen;
        CurrentScreen = ActiveScreen.GamePlayScreen;
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
        UI_Manager.Instance.CurrentScreen = ActiveScreen.HomeScreen;
    }

    public void Set_GameOver_Screen()
    {
        PreviousScreen = CurrentScreen;
        CurrentScreen = ActiveScreen.GameOverScreen;
        GameOver_Screen.EnableScreen();
    }

    public void Set_Quit_Screen()
    {
        PreviousScreen = CurrentScreen;
        quit_Screen.EnableScreen();
        CurrentScreen = ActiveScreen.QuitScreen;
    }


    public GameObject GetCurrentScreen()
    {
        if(CurrentScreen == ActiveScreen.HomeScreen)
        {
            return Home_Screen.gameObject;
        }else if(CurrentScreen == ActiveScreen.ToySelectionScreen)
        {
            return ToySelection_Screen.gameObject;
        }else if(CurrentScreen == ActiveScreen.GamePlayScreen)
        {
            return Game_Screen.gameObject;
        }else if(CurrentScreen == ActiveScreen.GameOverScreen)
        {
            return GameOver_Screen.gameObject;
        }
        return null;
    }




}
