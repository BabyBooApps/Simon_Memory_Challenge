using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    // List to store sound sequences for each level
    public List<List<int>> levels;

    public int No_Of_Sounds;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        // Initialize the list of levels with sound sequences
        levels = new List<List<int>>();

        // Add 50 levels to the list
       // SetLevels();
    }
    public List<List<int>> Levels { get; private set; }
   public void SetLevels(int num)
    {
        No_Of_Sounds = num;

        if (No_Of_Sounds == 5)
        {
            levels = new List<List<int>>
            {
            new List<int> { 1 },
            new List<int> { 3 },
            new List<int> { 2, 4 },
            new List<int> { 1, 5 },
            new List<int> { 2, 3, 1 },
            new List<int> { 4, 5, 2 },
            new List<int> { 1, 3, 5, 2 },
            new List<int> { 4, 1, 2, 5, 3 },
            new List<int> { 3, 2, 1, 5, 4, 2 },
            new List<int> { 1, 4, 3, 5, 2, 4, 1 },
            new List<int> { 5, 1, 3, 2, 4, 5, 1, 3 },
            new List<int> { 2, 4, 1, 5, 3, 2, 4, 1, 5 },
            new List<int> { 3, 5, 2, 4, 1, 3, 5, 2, 4, 1 },
            new List<int> { 1, 2, 3, 4, 5 },
            new List<int> { 5, 4, 3, 2, 1 },
            new List<int> { 2, 1, 4, 3, 5 },
            new List<int> { 3, 5, 1, 2, 4 },
            new List<int> { 4, 2, 5, 1, 3 },
            new List<int> { 1, 3, 2, 5, 4 },
            new List<int> { 4, 5, 1, 3, 2, 5 },
            new List<int> { 2, 1, 4, 3, 5, 2 },
            new List<int> { 5, 4, 1, 2, 3, 4, 5 },
            new List<int> { 1, 3, 5, 2, 4, 1, 3 },
            new List<int> { 2, 4, 1, 5, 3, 2, 4, 1, 5, 3 },
            new List<int> { 3, 5, 2, 4, 1, 3, 5, 2, 4, 1, 5 },
            new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 },
            new List<int> { 5, 4, 3, 2, 1, 5, 4, 3, 2, 1 },
            new List<int> { 2, 1, 4, 3, 5, 2, 1, 4, 3, 5 },
            new List<int> { 3, 5, 1, 2, 4, 3, 5, 1, 2, 4 },
            new List<int> { 4, 2, 5, 1, 3, 4, 2, 5, 1, 3 },
            new List<int> { 1, 3, 2, 5, 4, 1, 3, 2, 5, 4 },
            new List<int> { 4, 5, 1, 3, 2, 5, 4, 1, 3, 2, 5 },
            new List<int> { 2, 1, 4, 3, 5, 2, 1, 4, 3, 5, 2 },
            new List<int> { 5, 4, 1, 2, 3, 4, 5, 4, 1, 2, 3 },
            new List<int> { 1, 3, 5, 2, 4, 1, 3, 5, 2, 4, 1 },
            new List<int> { 2, 4, 1, 5, 3, 2, 4, 1, 5, 3, 2 },
            new List<int> { 3, 5, 2, 4, 1, 3, 5, 2, 4, 1, 5, 3 },
            new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2 },
            new List<int> { 5, 4, 3, 2, 1, 5, 4, 3, 2, 1, 5, 4 },
            new List<int> { 2, 1, 4, 3, 5, 2, 1, 4, 3, 5, 2, 1 },
            new List<int> { 3, 5, 1, 2, 4, 3, 5, 1, 2, 4, 3, 5 },
            new List<int> { 4, 2, 5, 1, 3, 4, 2, 5, 1, 3, 4, 2 },
            new List<int> { 1, 3, 2, 5, 4, 1, 3, 2, 5, 4, 1, 3 },
            new List<int> { 4, 5, 1, 3, 2, 5, 4, 1, 3, 2, 5, 4, 1 },
            new List<int> { 2, 1, 4, 3, 5, 2, 1, 4, 3, 5, 2, 1, 4 },
            new List<int> { 5, 4, 1, 2, 3, 4, 5, 4, 1, 2, 3, 5, 2 },
            new List<int> { 1, 3, 5, 2, 4, 1, 3, 5, 2, 4, 1, 3, 5 },
            new List<int> { 2, 4, 1, 5, 3, 2, 4, 1, 5, 3, 2, 4, 1, 5 },
            new List<int> { 3, 5, 2, 4, 1, 3, 5, 2, 4, 1, 5, 3, 2, 4 },
            new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 }
            };
        }else if(No_Of_Sounds == 4)
        {
            levels = new List<List<int>>
        {
            new List<int> { 1 },
            new List<int> { 2 },
            new List<int> { 3 },
            new List<int> { 4 },
            new List<int> { 1, 2 },
            new List<int> { 3, 4 },
            new List<int> { 2, 3, 1 },
            new List<int> { 4, 1, 2 },
            new List<int> { 3, 2, 4, 1 },
            new List<int> { 2, 4, 1, 3 },
            new List<int> { 1, 3, 2, 4 },
            new List<int> { 1, 2, 3, 4 },
            new List<int> { 4, 3, 2, 1 },
            new List<int> { 3, 4, 1, 2 },
            new List<int> { 2, 1, 4, 3 },
            new List<int> { 3, 1, 4, 2 },
            new List<int> { 1, 4, 2, 3 },
            new List<int> { 2, 3, 4, 1 },
            new List<int> { 1, 3, 2, 4, 1 },
            new List<int> { 4, 2, 1, 3, 4 },
            new List<int> { 3, 1, 2, 4, 3 },
            new List<int> { 2, 4, 3, 1, 2 },
            new List<int> { 2, 1, 4, 3, 2 },
            new List<int> { 1, 4, 3, 2, 1 },
            new List<int> { 4, 3, 2, 1, 4 },
            new List<int> { 3, 2, 1, 4, 3 },
            new List<int> { 2, 1, 4, 3, 2, 1 },
            new List<int> { 3, 4, 1, 2, 3, 4 },
            new List<int> { 2, 3, 4, 1, 2, 3 },
            new List<int> { 1, 2, 3, 4, 1, 2 },
            new List<int> { 4, 3, 2, 1, 4, 3 },
            new List<int> { 3, 4, 1, 2, 3, 4, 1 },
            new List<int> { 2, 1, 4, 3, 2, 1, 4 },
            new List<int> { 1, 4, 3, 2, 1, 4, 3, 2 },
            new List<int> { 4, 3, 2, 1, 4, 3, 2, 1 },
            new List<int> { 3, 4, 1, 2, 3, 4, 1, 2, 3 },
            new List<int> { 2, 1, 4, 3, 2, 1, 4, 3, 2 },
            new List<int> { 1, 4, 3, 2, 1, 4, 3, 2, 1 },
            new List<int> { 4, 3, 2, 1, 4, 3, 2, 1, 4 },
            new List<int> { 3, 4, 1, 2, 3, 4, 1, 2, 3, 4 },
            new List<int> { 2, 1, 4, 3, 2, 1, 4, 3, 2, 1 },
            new List<int> { 1, 4, 3, 2, 1, 4, 3, 2, 1, 4 },
            new List<int> { 4, 3, 2, 1, 4, 3, 2, 1, 4, 3 },
            new List<int> { 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1 },
            new List<int> { 2, 1, 4, 3, 2, 1, 4, 3, 2, 1, 4 },
            new List<int> { 1, 4, 3, 2, 1, 4, 3, 2, 1, 4, 3 },
            new List<int> { 4, 3, 2, 1, 4, 3, 2, 1, 4, 3, 2 },
            new List<int> { 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2 },
            new List<int> { 2, 1, 4, 3, 2, 1, 4, 3, 2, 1, 4, 3 },
            new List<int> { 1, 4, 3, 2, 1, 4, 3, 2, 1, 4, 3, 2 },
            new List<int> { 4, 3, 2, 1, 4, 3, 2, 1, 4, 3, 2, 1 },
            new List<int> { 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3 },
            new List<int> { 2, 1, 4, 3, 2, 1, 4, 3, 2, 1, 4, 3, 2 },
            new List<int> { 1, 4, 3, 2, 1, 4, 3, 2, 1, 4, 3, 2, 1 }
            };
        }else if(No_Of_Sounds == 6)
        {
            levels = new List<List<int>>
        {
            new List<int> { 1 },
            new List<int> { 2 },
            new List<int> { 3 },
            new List<int> { 4 },
            new List<int> { 5 },
            new List<int> { 6 },
            new List<int> { 1, 2 },
            new List<int> { 3, 4 },
            new List<int> { 5, 6 },
            new List<int> { 1, 3, 2 },
            new List<int> { 4, 6, 5 },
            new List<int> { 2, 5, 1, 4 },
            new List<int> { 3, 6, 2, 5 },
            new List<int> { 1, 5, 4, 2, 6 },
            new List<int> { 6, 3, 2, 1, 4 },
            new List<int> { 4, 2, 1, 3, 5, 6 },
            new List<int> { 1, 6, 3, 5, 2, 4 },
            new List<int> { 5, 4, 2, 6, 1, 3 },
            new List<int> { 2, 3, 5, 6, 1, 4 },
            new List<int> { 1, 4, 6, 2, 3, 5 },
            new List<int> { 3, 5, 1, 6, 4, 2 },
            new List<int> { 2, 6, 4, 1, 3, 5, 2 },
            new List<int> { 5, 3, 6, 4, 2, 1, 3 },
            new List<int> { 1, 2, 4, 5, 3, 6, 2, 1 },
            new List<int> { 3, 6, 5, 2, 4, 1, 3, 6 },
            new List<int> { 1, 4, 2, 5, 6, 3, 1, 4, 2 },
            new List<int> { 5, 6, 3, 1, 2, 4, 5, 6, 3 },
            new List<int> { 2, 3, 4, 5, 1, 6, 2, 3, 4, 5 },
            new List<int> { 1, 6, 5, 4, 3, 2, 1, 6, 5, 4 },
            new List<int> { 3, 2, 6, 1, 5, 4, 3, 2, 6, 1, 5 },
            new List<int> { 4, 5, 2, 3, 6, 1, 4, 5, 2, 3, 6 },
            new List<int> { 6, 1, 4, 5, 2, 3, 6, 1, 4, 5, 2 },
            new List<int> { 5, 3, 1, 6, 4, 2, 5, 3, 1, 6, 4 },
            new List<int> { 2, 4, 6, 1, 3, 5, 2, 4, 6, 1, 3, 5 },
            new List<int> { 3, 2, 5, 4, 1, 6, 3, 2, 5, 4, 1, 6 },
            new List<int> { 4, 5, 6, 3, 2, 1, 4, 5, 6, 3, 2, 1, 4 },
            new List<int> { 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1 },
            new List<int> { 1, 6, 5, 4, 3, 2, 1, 6, 5, 4, 3, 2 },
            new List<int> { 3, 2, 6, 1, 5, 4, 3, 2, 6, 1, 5, 4 },
            new List<int> { 4, 5, 2, 3, 6, 1, 4, 5, 2, 3, 6, 1 },
            new List<int> { 6, 1, 4, 5, 2, 3, 6, 1, 4, 5, 2, 3 },
            new List<int> { 5, 3, 1, 6, 4, 2, 5, 3, 1, 6, 4, 2 },
            new List<int> { 2, 4, 6, 1, 3, 5, 2, 4, 6, 1, 3, 5 },
            new List<int> { 3, 2, 5, 4, 1, 6, 3, 2, 5, 4, 1, 6 },
            new List<int> { 4, 5, 6, 3, 2, 1, 4, 5, 6, 3, 2, 1 },
            new List<int> { 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1 },
            new List<int> { 1, 6, 5, 4, 3, 2, 1, 6, 5, 4, 3, 2 },
            new List<int> { 3, 2, 6, 1, 5, 4, 3, 2, 6, 1, 5, 4 },
            new List<int> { 4, 5, 2, 3, 6, 1, 4, 5, 2, 3, 6, 1 },
            new List<int> { 6, 1, 4, 5, 2, 3, 6, 1, 4, 5, 2, 3 },
            new List<int> { 5, 3, 1, 6, 4, 2, 5, 3, 1, 6, 4, 2 }
        };
        }
    }

    //private void AddLevels()
    //{
    //    // Level 1
    //    levels.Add(new int[] { 2 });

    //    // Level 2
    //    levels.Add(new int[] { 1, 2 });

    //    // Level 3
    //    levels.Add(new int[] { 2, 1 });

    //    // Level 4
    //    levels.Add(new int[] { 3, 2, 1 });

    //    // Level 5
    //    levels.Add(new int[] { 4, 3, 2, 1 });

    //    // Level 6
    //    levels.Add(new int[] { 1, 2, 3, 4, 3 });

    //    // Level 7
    //    levels.Add(new int[] { 2, 1, 4, 3, 2, 1 });

    //    // Level 8
    //    levels.Add(new int[] { 3, 2, 1, 4, 3, 2, 1 });

    //    // Level 9
    //    levels.Add(new int[] { 4, 3, 2, 1, 2, 3, 4, 1 });

    //    // Level 10
    //    levels.Add(new int[] { 1, 2, 3, 4, 3, 2, 1, 4, 3 });

    //    // Level 11
    //    levels.Add(new int[] { 2, 1, 4, 3, 2, 1, 3, 4, 2, 1 });

    //    // Level 12
    //    levels.Add(new int[] { 3, 2, 1, 4, 3, 2, 1, 2, 3, 4, 1 });

    //    // Level 13
    //    levels.Add(new int[] { 4, 3, 2, 1, 2, 3, 4, 1, 3, 2, 4, 1 });

    //    // Level 14
    //    levels.Add(new int[] { 1, 2, 3, 4, 3, 2, 1, 4, 3, 2, 1, 2, 3 });

    //    // Level 15
    //    levels.Add(new int[] { 2, 1, 4, 3, 2, 1, 3, 4, 2, 1, 4, 3, 2, 1 });

    //    // Level 16
    //    levels.Add(new int[] { 3, 2, 1, 4, 3, 2, 1, 2, 3, 4, 1, 2, 3, 4, 1 });

    //    // Level 17
    //    levels.Add(new int[] { 4, 3, 2, 1, 2, 3, 4, 1, 3, 2, 4, 1, 3, 2, 4, 1 });

    //    // Level 18
    //    levels.Add(new int[] { 1, 2, 3, 4, 3, 2, 1, 4, 3, 2, 1, 2, 3, 4, 1, 2, 3 });

    //    // Level 19
    //    levels.Add(new int[] { 2, 1, 4, 3, 2, 1, 3, 4, 2, 1, 4, 3, 2, 1, 3, 4, 2, 1 });

    //    // Level 20
    //    levels.Add(new int[] { 3, 2, 1, 4, 3, 2, 1, 2, 3, 4, 1, 2, 3, 4, 1, 3, 2, 4, 1 });

    //    // Level 21
    //    levels.Add(new int[] { 4, 3, 2, 1, 2, 3, 4, 1, 3, 2, 4, 1, 3, 2, 4, 1, 2, 3, 4, 1 });

    //    // Level 22
    //    levels.Add(new int[] { 1, 2, 3, 4, 3, 2, 1, 4, 3, 2, 1, 2, 3, 4, 1, 2, 3, 4, 1, 4, 3 });

    //    // Level 23
    //    levels.Add(new int[] { 2, 1, 4, 3, 2, 1, 3, 4, 2, 1, 4, 3, 2, 1, 3, 4, 2, 1, 3, 4, 2, 1 });

    //    // Level 24
    //    levels.Add(new int[] { 3, 2, 1, 4, 3, 2, 1, 2, 3, 4, 1, 2, 3, 4, 1, 3, 2, 4, 1, 3, 2, 4, 1 });

    //    // Level 25
    //    levels.Add(new int[] { 4, 3, 2, 1, 2, 3, 4, 1, 3, 2, 4, 1, 3, 2, 4, 1, 2, 3, 4, 1, 4, 3, 2, 1 });

    //    // Continue adding levels up to Level 50...
    //}

    // Method to get a specific level's sound sequence
    public List<int> GetLevelSequence(int levelIndex)
    {
        if (levelIndex >= 0 && levelIndex < levels.Count)
        {
            return levels[levelIndex];
        }
        else
        {
            Debug.LogError("Invalid level index: " + levelIndex);
            return null;
        }
    }
}
