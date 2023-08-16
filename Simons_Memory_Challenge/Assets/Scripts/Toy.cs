using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour
{
    public List<Tile> Tiles = new List<Tile>();
    public int Toy_Id;
    public int Toy_Sounds_Count;

    private void Start()
    {
        getTiles();
    }

    public void getTiles()
    {
        Tiles.Clear();

        Tile[] Tiles_Array = GetComponentsInChildren<Tile>(true);

        Tiles.AddRange(Tiles_Array);

        Toy_Sounds_Count = Tiles_Array.Length;
    }

    public Tile GetTile(int Id)
    {
        Debug.Log("Expected Tile : " + Id);
        return Tiles[Id-1];
    }
}
