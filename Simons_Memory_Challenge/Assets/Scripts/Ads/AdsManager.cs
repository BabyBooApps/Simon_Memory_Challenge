using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;

public class AdsManager : MonoBehaviour
{
    public static AdsManager Instance;

    public  BannerViewController banner;
    public InterstitialAdController interstitial;
    public RewardedAdController RewardAd;
    // Start is called before the first frame update
    void Start()
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

        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
            //LoadInterstitialAd(); 
            interstitial.LoadAd();
            banner.LoadAd();
            RewardAd.LoadAd();

        });

       

       // banner.ShowAd();
    }
}
