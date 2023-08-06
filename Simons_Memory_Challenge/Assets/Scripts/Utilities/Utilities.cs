using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Utilities 
{
    public IEnumerator StartTimer(Text target , int timerValue)
    {
        yield return new WaitForEndOfFrame();

        int value = timerValue;
        while(timerValue >= 0)
        {
            target.text = timerValue.ToString();
            yield return new WaitForSeconds(1);

            timerValue--;
            
        }

    }

    





   
}
