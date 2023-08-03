using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour
{
    public List<Tile> Tiles = new List<Tile>();
    public int Toy_Id;

    private void Start()
    {
        getTiles();
    }

    public void getTiles()
    {
        Tiles.Clear();

        Tile[] Tiles_Array = GetComponentsInChildren<Tile>(true);

        Tiles.AddRange(Tiles_Array);
    }

    public Tile GetTile(int Id)
    {
        return Tiles[Id-1];
    }
}
