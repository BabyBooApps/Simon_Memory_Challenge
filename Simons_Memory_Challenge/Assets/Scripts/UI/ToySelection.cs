using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToySelection : UI_Screen
{
    public List<ToyTile> Toy_Tiles_Scriptables = new List<ToyTile>();
    public ToyTile_UI Toy_Tile_Prefab;
    public GameObject Toy_Selection_Tiles_Parent;
    


    public void PopulateToyTiles(int ToyCount)
    {
        for(int i = 0; i < ToyCount; i++)
        {
            ToyTile_UI Current_Tile = Instantiate(Toy_Tile_Prefab) as ToyTile_UI;
            Current_Tile.transform.parent = Toy_Selection_Tiles_Parent.transform;
            Current_Tile.transform.localScale = Vector3.one;
            SetToyTile(Current_Tile, Toy_Tiles_Scriptables[i]);
        }
    }

    public void SetToyTile(ToyTile_UI toy , ToyTile Target_toy_Tile)
    {
        toy.Name.text = Target_toy_Tile.ToyName;
        toy.Toy_Image.sprite = Target_toy_Tile.Toy_Img;
        toy.Toy_id = Target_toy_Tile.Toy_Id;
    }

    public void ToyTile_Clicked(int toyId)
    {
        Debug.Log("clicked on : " + toyId);
        UI_Mgr.OnToySelected(toyId);
        
    }
   
}
