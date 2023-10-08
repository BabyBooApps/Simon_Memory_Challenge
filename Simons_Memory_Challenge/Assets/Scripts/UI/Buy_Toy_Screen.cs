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

    public void SetScreen(ToyTile_UI toy)
    {
        
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
}
