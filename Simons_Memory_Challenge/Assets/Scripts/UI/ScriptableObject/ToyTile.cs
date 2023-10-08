using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ToyTile", menuName = "Custom/ToyTile")]
public class ToyTile : ScriptableObject
{
    public Sprite Tile_Bg;
    public Sprite Toy_Img;
    public string ToyName;
    public int Toy_Id;
    public int CoinsToBuy;
 
}
