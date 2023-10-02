using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScreen : UI_Screen
{
    public void OnQuitButtonClick()
    {
        AudioManager.Instance.PlayShortSound(AudioManager.Instance.Button_Click);
        Application.Quit();
    }

    public void OnCancelButtonClick()
    {
        AudioManager.Instance.PlayShortSound(AudioManager.Instance.Button_Click);
        UI_Manager.Instance.SetHomeScreen();
        DisableScreen();
       
    }

}
