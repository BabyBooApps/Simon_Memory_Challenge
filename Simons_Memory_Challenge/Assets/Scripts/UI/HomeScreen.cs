using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreen : UI_Screen
{
    public Button NoAdsBtn;
    

    public void Set_No_Ads_Btn()
    {
        NoAdsBtn.enabled = !PlayerPrefs_Manager.Instance.GetNoAdsStatus();
    }
    public void OnFreeRun_Btn_Click()
    {
        AudioManager.Instance.PlayShortSound(AudioManager.Instance.Button_Click);
        GameData.Instance.gameType = GameType.FreeTrial;
        Execute_Play();
       
    }

    public void OnChallenge_Button_Clicked()
    {
        AudioManager.Instance.PlayShortSound(AudioManager.Instance.Button_Click);
        GameData.Instance.gameType = GameType.SinglePlayer;
        Execute_Play();
       
    }

    public void Execute_Play()
    {
        AudioManager.Instance.PlayShortSound(AudioManager.Instance.Button_Click);
        this.gameObject.SetActive(false);
        UI_Mgr.Set_ToyselectionScreen();
    }

    public void OnCoinStore_Btn_Cick()
    {
        //AdsManager.Instance.RewardAd.ShowAd();
        UI_Manager.Instance.Activate_CoinStore_Screen();
    }
}
