using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class GamePlay : MonoBehaviour
{

    public static GamePlay Instance;
    Glow Glow_Obj;
    Toy ActiveToy;
    UI_Manager UI_Mgr;

    public ToyManager ToyMgr;
    Utilities Timer = new Utilities();

    private void Awake()
    {
        // Ensure that only one instance of the class exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional: Prevent the object from being destroyed when loading new scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances of the singleton class
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ToyMgr = FindAnyObjectByType(typeof(ToyManager)) as ToyManager;
        UI_Mgr = FindAnyObjectByType(typeof(UI_Manager)) as UI_Manager;
        Glow_Obj = FindAnyObjectByType(typeof(Glow)) as Glow;
        GameData.Instance.SetDemoData();
        //SetGame();
        
    }

    public void SetGame()
    {
       
        SpawnToy();
        if(GameData.Instance.gameType != GameType.FreeTrial)
        {
            StartCoroutine(Start_GamePlay());
        }else
        {
            GameData.Instance.GameTurn = Turn.Player;
        }
       
    }

    IEnumerator Start_GamePlay()
    {
        GameData.Instance.Game_State = GameState.Hold;
        yield return new WaitForSeconds(0.5f);
        UI_Manager.Instance.Game_Screen.Turn_Text.text = "Computer Turn";
        UI_Mgr.Game_Screen.TimerPanel.SetActive(true);
        UI_Manager.Instance.Game_Screen.Timer_Txt.text = 1.ToString();
        yield return new WaitForSeconds(0.5f);
        GameData.Instance.Toy_Sounds_Count = ActiveToy.Toy_Sounds_Count;
        SetLevelData(GameData.Instance.Level_No);
        yield return StartCoroutine(Timer.StartTimer(UI_Manager.Instance.Game_Screen.Timer_Txt, 1));
        UI_Manager.Instance.Game_Screen.Turn_Info.SetActive(false);

       

        if (GameData.Instance.gameType == GameType.SinglePlayer)
        {
            
            GameData.Instance.Game_State = GameState.Playing;
            GameData.Instance.GameTurn = Turn.Computer;
            yield return Automate(GameData.Instance.LevelData);
            GameData.Instance.Game_State = GameState.Hold;
            GameData.Instance.GameTurn = Turn.Player;
            UI_Manager.Instance.Game_Screen.Turn_Text.text = "Player Turn";
            UI_Manager.Instance.Game_Screen.Turn_Info.SetActive(true);
            yield return StartCoroutine(Timer.StartTimer(UI_Manager.Instance.Game_Screen.Timer_Txt, 1));
            UI_Mgr.Game_Screen.TimerPanel.SetActive(false);
            GameData.Instance.Game_State = GameState.Playing;
        }
        if (GameData.Instance.gameType == GameType.FreeTrial)
        {
            GameData.Instance.GameTurn = Turn.Player;
        }
    }



    public void SpawnToy()
    {
        ActiveToy = Instantiate(ToyMgr.GetToy(GameData.Instance.Toy_Id));
        ActiveToy.transform.position = new Vector3(0, -0.5f, 0);
        
    }

    public void DestroyToy()
    {
        Destroy(ActiveToy.gameObject);
        ActiveToy = null;
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
            if(GameData.Instance.gameType == GameType.FreeTrial)
            {
                Tile tile = GetTile_performGlowAndSound(id);
            }
            

            if (GameData.Instance.GameTurn == Turn.Player && GameData.Instance.gameType != GameType.FreeTrial && GameData.Instance.Game_State == GameState.Playing)
            {
                Tile tile = GetTile_performGlowAndSound(id);
                if (isCorrectClick(tile.TileID))
                {
                    Debug.Log("Correct click");
                    GameData.Instance.Score++;
                    GameData.Instance.Click_Count++;
                    UI_Manager.Instance.Game_Screen.set_Score(GameData.Instance.Score);
                    if(IsLevelCompleted(GameData.Instance.Score))
                    {
                        OnLevelCompleted();
                    }
                    
                }
                else
                {
                    Debug.Log("Wrong click");
                    OnLevelFailed();
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
        Debug.Log("Expected click : " + GameData.Instance.GetTargetClickId() + "But Clicked On : " + id);
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
    IEnumerator Automate(List<int> levelData)
    {
        yield return new WaitForEndOfFrame();
        for (int i = 0; i < levelData.Count; i++)
        {
            GetTile_performGlowAndSound(levelData[i]);

            yield return new WaitForSeconds(1);
        }


    }

    void SetLevelData(int levelNo)
    {

       // GameData.Instance.LevelData = new int[LevelManager.instance.GetLevelSequence(levelNo).Length];
        LevelManager.instance.SetLevels(GameData.Instance.Toy_Sounds_Count);

        GameData.Instance.LevelData = LevelManager.instance.GetLevelSequence(levelNo);

        Debug.Log("LevelData : " + GameData.Instance.LevelData);
    }

    public void OnLevelCompleted()
    {
        Debug.Log("LevelCompleted Successfully");
        SetNextLevel();
    }

    public void OnLevelFailed()
    {
        Debug.Log("Level Failed !!!");
        UI_Mgr.Set_GameOver_Screen();
    }

    public bool IsLevelCompleted(int score)
    {
        if(score == GameData.Instance.LevelData.Count)
        {
            return true;
        }

        return false;
    }

    public void SetNextLevel()
    {
        GameData.Instance.Level_No++;
        GameData.Instance.Score = 0;
        GameData.Instance.Click_Count = 0;
        GameData.Instance.GameTurn = Turn.Computer;
        UI_Manager.Instance.Game_Screen.set_Score(GameData.Instance.Score);
        UI_Manager.Instance.Game_Screen.set_LevelNo(GameData.Instance.Level_No);
        StartCoroutine(Start_GamePlay());
    }
}


