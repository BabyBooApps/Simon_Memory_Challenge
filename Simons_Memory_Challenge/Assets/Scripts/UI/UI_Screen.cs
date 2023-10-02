using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Screen : MonoBehaviour
{
    public UI_Manager UI_Mgr;
    public CanvasGroup canvas_group;

    public void Start()
    {
        UI_Mgr = FindAnyObjectByType(typeof(UI_Manager)) as UI_Manager;
    }
    public void EnableScreen()
    {
        this.gameObject.SetActive(true);
        canvas_group.alpha = 0;
        FadeIN();
    }

    public void DisableScreen()
    {
        FadeOut();
        this.gameObject.SetActive(false);

    }

    public void FadeIN()
    {
        iTween.ValueTo(gameObject, iTween.Hash(
            "from", 0f,
            "to", 1f,
            "time", 0.75f,
            "onupdate", "UpdateAlpha",
            "easetype", iTween.EaseType.easeInOutSine
        ));
    }

    public void FadeOut()
    {
        iTween.ValueTo(gameObject, iTween.Hash(
            "from", 1f,
            "to", 0f,
            "time", 0.5f,
            "onupdate", "UpdateAlpha",
            "easetype", iTween.EaseType.easeInOutSine
        ));
    }

    private void UpdateAlpha(float alpha)
    {
        if (canvas_group != null)
        {
            canvas_group.alpha = alpha;
        }
    }
}
