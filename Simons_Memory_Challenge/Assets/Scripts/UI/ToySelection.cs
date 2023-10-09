using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToySelection : UI_Screen
{
    public List<ToyTile> Toy_Tiles_Scriptables = new List<ToyTile>();
    public ToyTile_UI Toy_Tile_Prefab;
    public GameObject Toy_Selection_Tiles_Parent;
    public List<ToyTile_UI> PopulatedTiles = new List<ToyTile_UI>();
    


    public void PopulateToyTiles(int ToyCount)
    {
       if(PopulatedTiles.Count != 0)
        {
            return;
        }
        for(int i = 0; i < ToyCount; i++)
        {
            ToyTile_UI Current_Tile = Instantiate(Toy_Tile_Prefab) as ToyTile_UI;
            Current_Tile.transform.parent = Toy_Selection_Tiles_Parent.transform;
            Current_Tile.transform.localScale = Vector3.one;
            PopulatedTiles.Add(Current_Tile);
            SetToyTile(Current_Tile, Toy_Tiles_Scriptables[i]);
        }

        RefreshTiles();
    }

    public void SetToyTile(ToyTile_UI toy , ToyTile Target_toy_Tile)
    {
        toy.Toy_Name = Target_toy_Tile.ToyName;
        toy.ToyName.text = Target_toy_Tile.ToyName;
        toy.Toy_Image.sprite = Target_toy_Tile.Toy_Img;
        toy.Toy_id = Target_toy_Tile.Toy_Id;
        toy.coinsToBuy = Target_toy_Tile.CoinsToBuy;
    }

    public void RefreshTiles()
    {
        for(int i = 0; i < PopulatedTiles.Count; i++)
        {
            PopulatedTiles[i].Lock_Img.gameObject.SetActive(!PlayerPrefs_Manager.Instance.GetLockStatus(PopulatedTiles[i].Toy_Name));
        }
    }

    public void ToyTile_Clicked(int toyId)
    {
        Debug.Log("clicked on : " + toyId);
        UI_Mgr.OnToySelected(toyId);
        
    }

    public void On_CoinStoreButtonClick()
    {
        UI_Manager.Instance.Activate_CoinStore_Screen();
    }
   
}
