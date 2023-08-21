using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : UI_Screen
{
   public void OnPlayAgainClicked()
    {
        UI_Mgr.Set_ToyselectionScreen();
        DisableScreen();
    }

    public void OnGoHomeClicked()
    {
        UI_Mgr.SetHomeScreen();
        DisableScreen();
    }
}
