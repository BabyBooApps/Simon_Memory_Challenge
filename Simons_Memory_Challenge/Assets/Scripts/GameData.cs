using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData Instance;
    public bool TestMode;
    public int Toy_Id { get; set; }

    public int Toy_Sounds_Count;
    public int Level_No { get; set; }

    public List<int> LevelData = new List<int>();

    public int Click_Count = 0;
    public int Target_Click_Id = 0;

    public GameType gameType;

    public Turn GameTurn;

    public GameState Game_State;
    public int Score { get; set; }

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

    private void Start()
    {
       // SetDemoData();
    }



    public void SetDemoData()
    {
        
        Level_No = 54;
        gameType = GameType.FreeTrial;
    }

    public int GetTargetClickId()
    {
        if(LevelData.Count > Click_Count)
        return LevelData[Click_Count];

        return -1;
    }
    
}
