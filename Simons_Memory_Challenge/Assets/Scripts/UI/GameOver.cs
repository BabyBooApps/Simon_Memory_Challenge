using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : UI_Screen
{
   public void OnPlayAgainClicked()
    {
        GamePlay.Instance.DestroyToy();
        UI_Mgr.ToySelection_Screen.EnableScreen();
        UI_Manager.Instance.CurrentScreen = ActiveScreen.ToySelectionScreen;
        DisableScreen();
    }

    public void OnGoHomeClicked()
    {
        GamePlay.Instance.DestroyToy();
        UI_Mgr.SetHomeScreen();
        GameData.Instance.Level_No = 0;
        GameData.Instance.Score = 0;
        GameData.Instance.Click_Count = 0;
        DisableScreen();
    }
}
