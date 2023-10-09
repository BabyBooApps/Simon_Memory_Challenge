using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy_Toy_Screen : UI_Screen
{
    public Text ToyName;
    public Image ToyImage;
    public Text CoinsNeeded;
    public Text Warning;
    public Button BuyButton;
    public ToyTile_UI Toy;

    public void SetScreen(ToyTile_UI toy)
    {
        Toy = toy;

        ToyName.text = toy.Toy_Name.ToString();
        ToyImage.sprite = toy.Toy_Image.sprite;
        CoinsNeeded.text = toy.coinsToBuy.ToString();

        bool IsEnoughCoins = (toy.coinsToBuy > Coin_Manager.Instance.getCoinCount());
        BuyButton.enabled = (!IsEnoughCoins);
        if(!IsEnoughCoins)
        {
            BuyButton.GetComponent<Image>().color = Color.green;
        }else
        {
            BuyButton.GetComponent<Image>().color = Color.red;
        }

        Warning.gameObject.SetActive(IsEnoughCoins);
        
    }

    public void OnBackButton_Click()
    {
        Toy = null;
        UI_Manager.Instance.CurrentScreen = ActiveScreen.ToySelectionScreen;
        UI_Manager.Instance.PreviousScreen = ActiveScreen.HomeScreen;
        DisableScreen();

    }

    public void OnBuyButtonClick()
    {
        if(Toy)
        {
            if(Toy.coinsToBuy <= Coin_Manager.Instance.getCoinCount())
            {
                PlayerPrefs_Manager.Instance.SetToy_LockStatsu(Toy.Toy_Name, 1);
                Toy.isUnlocked = true;
                UI_Manager.Instance.Animate_Toast("You Owned " + Toy.Toy_Name.ToUpper() + " !!!");
                Coin_Manager.Instance.RemoveCoins(Toy.coinsToBuy);
                PlayerPrefs_Manager.Instance.SetCoins(Coin_Manager.Instance.getCoinCount());
                UI_Manager.Instance.ToySelection_Screen.RefreshTiles();
                OnBackButton_Click();
            }else
            {
                Debug.Log("Not enough coins!!!");
            }
        }
    }

    public void OnWatchAd_Button_Click()
    {
        AdsManager.Instance.RewardAd.ShowAd();
    }

    public void OnCoinStoreButtonClick()
    {
        UI_Manager.Instance.Activate_CoinStore_Screen();
    }


}
