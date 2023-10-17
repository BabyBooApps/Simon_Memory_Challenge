using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Manager : MonoBehaviour
{
    public static Coin_Manager Instance;

    public int CoinCount;

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
        CoinCount = count;

    }

    public int getCoinCount()
    {
        return CoinCount;
    }

    public void AddCoins(int count)
    {
        CoinCount += count;
    }

    public void RemoveCoins(int count)
    {
        CoinCount -= count;
    }

}

public static class Coin_Bonus
{
    public static List<int> CoinBonus = new List<int>
    {
        11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
        25, 30, 35, 40, 45, 50, 55, 60, 65, 70,
        80, 90, 100, 110, 120, 130, 140, 150, 160, 170,
        185, 200, 215, 230, 245, 260, 275, 290, 305, 320,
        340, 360, 380, 400, 420, 440, 460, 480, 500, 520,
        540,560,580,600,620,640
    };
}

