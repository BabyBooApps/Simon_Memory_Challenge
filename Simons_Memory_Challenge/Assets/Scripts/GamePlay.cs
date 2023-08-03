using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    Glow Glow_Obj;
    Toy ActiveToy;
    int Level_No = 24;
    int[] LevelData;
    // Start is called before the first frame update
    void Start()
    {
        Glow_Obj = FindAnyObjectByType(typeof(Glow)) as Glow;
        ActiveToy = FindObjectOfType(typeof(Toy)) as Toy;
        SetLevelData(Level_No);
       // AutomateLevel();
    }

    public void MouseClicked()
    {
        Debug.Log("Mouse Click recieved in GamePlay");
        Tile ClickedTile = GetClickedTile();
        PerformClick(ClickedTile.TileID);
    }

    public void PerformClick(int id)
    {
        Tile tile = ActiveToy.GetTile(id);
        Glow_Obj.ActivateGlow(tile.Glow, tile.transform.position);
        AudioManager.Instance.PlayShortSound(tile.clip);
    }

    public Tile GetClickedTile()
    {
        // Create a ray from the mouse position into the scene
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

        // Check if the raycast hits any collider in the scene
        if (hit.collider != null)
        {
            // You can access the GameObject, do something with it, or its components
            GameObject clickedObject = hit.collider.gameObject;
            if (clickedObject.GetComponent<IInteractable>() != null)
            {
                clickedObject.GetComponent<IInteractable>().OnTileClicked();
            }

            Tile clickedTile = clickedObject.GetComponent<Tile>();
            return clickedTile;
        }


        return null;
    }

    void AutomateLevel()
    {
        StartCoroutine(Automate(LevelData));
    }

    IEnumerator Automate(int[] levelData)
    {
        yield return new WaitForEndOfFrame();
         for(int i = 0; i < levelData.Length; i++)
        {
            PerformClick(LevelData[i]);

            yield return new WaitForSeconds(1);
        }
    }

    void SetLevelData(int levelNo)
    {
        LevelData = new int[LevelManager.instance.GetLevelSequence(levelNo).Length];

        LevelData = LevelManager.instance.GetLevelSequence(levelNo);

        Debug.Log("LevelData : " + LevelData);
    }
    

   
}


