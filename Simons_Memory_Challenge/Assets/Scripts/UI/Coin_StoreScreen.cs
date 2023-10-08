using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_StoreScreen : UI_Screen
{
    public void OnBackButtonClicked()
    {
        ActiveScreen tempScreen = UI_Manager.Instance.CurrentScreen;
        UI_Manager.Instance.CurrentScreen = UI_Manager.Instance.PreviousScreen;
        UI_Manager.Instance.PreviousScreen = tempScreen;

        DisableScreen();
    }

    public void OnWatch_Ad_Button_Click()
    {
        AdsManager.Instance.RewardAd.ShowAd();
    }
}
