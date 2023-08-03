using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    // List to store sound sequences for each level
    public List<int[]> levels;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        // Initialize the list of levels with sound sequences
        levels = new List<int[]>();

        // Add 50 levels to the list
        AddLevels();
    }

    private void AddLevels()
    {
        // Level 1
        levels.Add(new int[] { 2 });

        // Level 2
        levels.Add(new int[] { 1, 2 });

        // Level 3
        levels.Add(new int[] { 2, 1 });

        // Level 4
        levels.Add(new int[] { 3, 2, 1 });

        // Level 5
        levels.Add(new int[] { 4, 3, 2, 1 });

        // Level 6
        levels.Add(new int[] { 1, 2, 3, 4, 3 });

        // Level 7
        levels.Add(new int[] { 2, 1, 4, 3, 2, 1 });

        // Level 8
        levels.Add(new int[] { 3, 2, 1, 4, 3, 2, 1 });

        // Level 9
        levels.Add(new int[] { 4, 3, 2, 1, 2, 3, 4, 1 });

        // Level 10
        levels.Add(new int[] { 1, 2, 3, 4, 3, 2, 1, 4, 3 });

        // Level 11
        levels.Add(new int[] { 2, 1, 4, 3, 2, 1, 3, 4, 2, 1 });

        // Level 12
        levels.Add(new int[] { 3, 2, 1, 4, 3, 2, 1, 2, 3, 4, 1 });

        // Level 13
        levels.Add(new int[] { 4, 3, 2, 1, 2, 3, 4, 1, 3, 2, 4, 1 });

        // Level 14
        levels.Add(new int[] { 1, 2, 3, 4, 3, 2, 1, 4, 3, 2, 1, 2, 3 });

        // Level 15
        levels.Add(new int[] { 2, 1, 4, 3, 2, 1, 3, 4, 2, 1, 4, 3, 2, 1 });

        // Level 16
        levels.Add(new int[] { 3, 2, 1, 4, 3, 2, 1, 2, 3, 4, 1, 2, 3, 4, 1 });

        // Level 17
        levels.Add(new int[] { 4, 3, 2, 1, 2, 3, 4, 1, 3, 2, 4, 1, 3, 2, 4, 1 });

        // Level 18
        levels.Add(new int[] { 1, 2, 3, 4, 3, 2, 1, 4, 3, 2, 1, 2, 3, 4, 1, 2, 3 });

        // Level 19
        levels.Add(new int[] { 2, 1, 4, 3, 2, 1, 3, 4, 2, 1, 4, 3, 2, 1, 3, 4, 2, 1 });

        // Level 20
        levels.Add(new int[] { 3, 2, 1, 4, 3, 2, 1, 2, 3, 4, 1, 2, 3, 4, 1, 3, 2, 4, 1 });

        // Level 21
        levels.Add(new int[] { 4, 3, 2, 1, 2, 3, 4, 1, 3, 2, 4, 1, 3, 2, 4, 1, 2, 3, 4, 1 });

        // Level 22
        levels.Add(new int[] { 1, 2, 3, 4, 3, 2, 1, 4, 3, 2, 1, 2, 3, 4, 1, 2, 3, 4, 1, 4, 3 });

        // Level 23
        levels.Add(new int[] { 2, 1, 4, 3, 2, 1, 3, 4, 2, 1, 4, 3, 2, 1, 3, 4, 2, 1, 3, 4, 2, 1 });

        // Level 24
        levels.Add(new int[] { 3, 2, 1, 4, 3, 2, 1, 2, 3, 4, 1, 2, 3, 4, 1, 3, 2, 4, 1, 3, 2, 4, 1 });

        // Level 25
        levels.Add(new int[] { 4, 3, 2, 1, 2, 3, 4, 1, 3, 2, 4, 1, 3, 2, 4, 1, 2, 3, 4, 1, 4, 3, 2, 1 });

        // Continue adding levels up to Level 50...
    }

    // Method to get a specific level's sound sequence
    public int[] GetLevelSequence(int levelIndex)
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
