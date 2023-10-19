using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxLevelReached : UI_Screen
{
    public void OnHomeBtnClicked()
    {
        AudioManager.Instance.PlayShortSound(AudioManager.Instance.Button_Click);
        UI_Manager.Instance.SetHomeScreen();
        this.DisableScreen();
    }
}
