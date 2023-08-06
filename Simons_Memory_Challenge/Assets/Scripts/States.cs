using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class States 
{
    
}

public enum GameState
{
    Playing,
    Pause,
    Hold,
    Completed,
    Fail
}

public enum Difficulty_Level
{
    Easy,
    Medium,
    Hard
}

public enum GameType
{
    FreeTrial,
    SinglePlayer,
    Multiplayer

}

public enum Turn
{
    Computer,
    Player
}
