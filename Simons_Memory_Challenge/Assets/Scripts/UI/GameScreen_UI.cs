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
        set_LevelNo(GameData.Instance.Level_No);
        set_Score(GameData.Instance.Score);

        GamePlay.Instance.SetGame();
    }

    public void set_LevelNo(int value)
    {
        Level_Txt.text = value.ToString();
    }

    public void set_Score(int value)
    {
        Score_Txt.text = value.ToString();
    }
}
