using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toast : UI_Screen
{
    public Text Mesage_Txt;
    public void ActivateToast(string message)
    {
        Mesage_Txt.text = message;
    }

    public IEnumerator Animate_Toast(string message)
    {
        ActivateToast(message);

        yield return new WaitForSeconds(2.0f);

        DisableScreen();
    }

}
