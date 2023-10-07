using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefs_Manager : MonoBehaviour
{
    public static PlayerPrefs_Manager Instance;


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
    }

    public void SetCoins(int count)
    {
        PlayerPrefs.SetInt("Coins", count);
    }

    public int GetCoins()
    {
        return PlayerPrefs.GetInt("Coins");
    }
}
