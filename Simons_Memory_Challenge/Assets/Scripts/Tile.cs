using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour , IInteractable
{
    public int TileID;
    public Sprite Glow;
    public AudioClip clip;
    public void OnTileClicked()
    {
        Debug.Log("Clicked On Tile : " + TileID);
    }
}
