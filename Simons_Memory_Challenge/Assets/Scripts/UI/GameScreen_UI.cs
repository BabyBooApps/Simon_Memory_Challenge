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
        Turn_Text.gameObject.SetActive(GameData.Instance.gameType != GameType.FreeTrial);
        Timer_Txt.gameObject.SetActive(GameData.Instance.gameType != GameType.FreeTrial);
        Level_Txt.gameObject.SetActive(GameData.Instance.gameType != GameType.FreeTrial);
        Score_Txt.gameObject.SetActive(GameData.Instance.gameType != GameType.FreeTrial);
      
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
}
