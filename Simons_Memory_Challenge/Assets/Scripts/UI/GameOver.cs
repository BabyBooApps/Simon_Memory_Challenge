using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : UI_Screen
{
   public void OnPlayAgainClicked()
    {
        GamePlay.Instance.DestroyToy();
        UI_Mgr.ToySelection_Screen.EnableScreen();
        DisableScreen();
    }

    public void OnGoHomeClicked()
    {
        GamePlay.Instance.DestroyToy();
        UI_Mgr.SetHomeScreen();
        DisableScreen();
    }
}
