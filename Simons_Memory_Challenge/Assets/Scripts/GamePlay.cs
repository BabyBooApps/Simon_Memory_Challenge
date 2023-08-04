using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    Glow Glow_Obj;
    Toy ActiveToy;


    ToyManager ToyMgr;

    // Start is called before the first frame update
    void Start()
    {
        ToyMgr = FindAnyObjectByType(typeof(ToyManager)) as ToyManager;
        Glow_Obj = FindAnyObjectByType(typeof(Glow)) as Glow;


        StartCoroutine(Start_GamePlay());
    }

    IEnumerator Start_GamePlay()
    {
        yield return new WaitForSeconds(1);
        SetLevelData(GameData.Instance.Level_No);
        SpawnToy();
        if (GameData.Instance.gameType == GameType.SinglePlayer)
        {
            GameData.Instance.GameTurn = Turn.Computer;
            yield return Automate(GameData.Instance.LevelData);
            GameData.Instance.GameTurn = Turn.Player;
        }
        if (GameData.Instance.gameType == GameType.FreeTrial)
        {
            GameData.Instance.GameTurn = Turn.Player;
        }
    }



    public void SpawnToy()
    {
        ActiveToy = Instantiate(ToyMgr.GetToy(GameData.Instance.Toy_Id));
    }

    public void MouseClicked()
    {
        Debug.Log("Mouse Click recieved in GamePlay");
        Tile ClickedTile = GetClickedTile();
        if (ClickedTile)
            PerformClick(ClickedTile.TileID);
    }

    public void PerformClick(int id)
    {
        if (GameData.Instance.GameTurn != Turn.Computer)
        {

            Tile tile = GetTile_performGlowAndSound(id);

            if (GameData.Instance.GameTurn == Turn.Player && GameData.Instance.gameType != GameType.FreeTrial)
            {
                if (isCorrectClick(tile.TileID))
                {
                    GameData.Instance.Click_Count++;
                    Debug.Log("Correct click");
                }
                else
                {
                    Debug.Log("Wrong click");
                }
            }
        }

    }

    Tile GetTile_performGlowAndSound(int Id)
    {
        Tile tile = ActiveToy.GetTile(Id);
        Glow_Obj.ActivateGlow(tile.Glow, tile.transform.position);
        AudioManager.Instance.PlayShortSound(tile.clip);

        return tile;
    }

    bool isCorrectClick(int id)
    {
        if (GameData.Instance.GetTargetClickId() == id)
        {

            return true;
        }
        return false;
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
    IEnumerator Automate(int[] levelData)
    {
        yield return new WaitForEndOfFrame();
        for (int i = 0; i < levelData.Length; i++)
        {
            GetTile_performGlowAndSound(levelData[i]);

            yield return new WaitForSeconds(1);
        }


    }

    void SetLevelData(int levelNo)
    {
        GameData.Instance.LevelData = new int[LevelManager.instance.GetLevelSequence(levelNo).Length];

        GameData.Instance.LevelData = LevelManager.instance.GetLevelSequence(levelNo);

        Debug.Log("LevelData : " + GameData.Instance.LevelData);
    }

}


