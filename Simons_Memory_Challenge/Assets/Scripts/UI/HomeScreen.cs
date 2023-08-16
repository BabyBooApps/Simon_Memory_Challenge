using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScreen : UI_Screen
{
    public void OnFreeRun_Btn_Click()
    {
        Execute_Play();
        GameData.Instance.gameType = GameType.FreeTrial;
    }

    public void OnChallenge_Button_Clicked()
    {
        Execute_Play();
        GameData.Instance.gameType = GameType.SinglePlayer;
    }

    public void Execute_Play()
    {
        this.gameObject.SetActive(false);
        UI_Mgr.Set_ToyselectionScreen();
    }
}
