using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    GamePlay GamePlayController;
    // Start is called before the first frame update
    void Start()
    {
        GamePlayController = FindAnyObjectByType(typeof(GamePlay)) as GamePlay;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           // Debug.Log("Mouse Clicked");
            GamePlayController.MouseClicked();
        }
    }
}
