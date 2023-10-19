using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefs_Manager : MonoBehaviour
{
    public static PlayerPrefs_Manager Instance;
    public const string NoAds_String = "NoAds";
    public bool DeleteAllPlayerPrefs;
    public List<string> ActivatedToys = new List<string>();
    

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
        if(DeleteAllPlayerPrefs)
        {
            PlayerPrefs.DeleteAll();
        }
       
    }
    private void Start()
    {
        ActivateToys();
    }

    public void SetCoins(int count)
    {
        PlayerPrefs.SetInt("Coins", count);
    }

    public int GetCoins()
    {
        return PlayerPrefs.GetInt("Coins");
    }

    public void ActivateToys()
    {
        for(int i = 0; i < ActivatedToys.Count; i++)
        {
            SetToy_LockStatsu(ActivatedToys[i], 1);
        }
    }

    public void SetToy_LockStatsu(string toyId , int Lockstatus)
    {
        PlayerPrefs.SetInt(toyId, Lockstatus);
    }

    public bool GetLockStatus(string toyId)
    {
        bool isToyUnlocked = false;
        isToyUnlocked = PlayerPrefs.GetInt(toyId) == 1 ? true : false;

        return isToyUnlocked;
    }

    public void Set_No_Ads_Status(bool adsStatus)
    {
        int adStatus = (adsStatus == true ? 1 : 0);
        PlayerPrefs.SetInt(NoAds_String, adStatus);

    }

    public bool GetNoAdsStatus()
    {
        return PlayerPrefs.GetInt(NoAds_String) == 1 ? true : false;
    }
}
