using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScreen_UI : UI_Screen
{
    public Text Level_Txt;
    public Text Score_Txt;
    public Text Timer_Txt;
    public Text Turn_Text;

    public GameObject Level_Panel;
    public GameObject ScorePanel;
    public GameObject TimerPanel;

    public GameObject Turn_Info;

    public void ActivateScreen()
    {
        EnableScreen();
        SetScreen();
        set_LevelNo(GameData.Instance.Level_No);
        set_Score(GameData.Instance.Score);

        GamePlay.Instance.SetGame();
    }

    public void SetScreen()
    {
        Level_Panel.SetActive(GameData.Instance.gameType != GameType.FreeTrial);
        ScorePanel.SetActive(GameData.Instance.gameType != GameType.FreeTrial);
        TimerPanel.SetActive(GameData.Instance.gameType != GameType.FreeTrial);
      
    }

    public void set_LevelNo(int value)
    {
        if(GameData.Instance.gameType != GameType.FreeTrial)
        Level_Txt.text = value.ToString();
    }

    public void set_Score(int value)
    {
        if (GameData.Instance.gameType != GameType.FreeTrial)
            Score_Txt.text = value.ToString();
    }

    public void OnHomeBtn_Click()
    {
        GamePlay.Instance.DestroyToy();
        UI_Mgr.SetHomeScreen();
        GameData.Instance.Level_No = 0;
        GameData.Instance.Score = 0;
        GameData.Instance.Click_Count = 0;
        DisableScreen();
    }
}
