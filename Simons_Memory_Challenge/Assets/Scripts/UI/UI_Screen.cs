using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Screen : MonoBehaviour
{
    public UI_Manager UI_Mgr;

    public void Start()
    {
        UI_Mgr = FindAnyObjectByType(typeof(UI_Manager)) as UI_Manager;
    }
    public void EnableScreen()
    {
        this.gameObject.SetActive(true);
    }

    public void DisableScreen()
    {
        this.gameObject.SetActive(false);
    }
}
