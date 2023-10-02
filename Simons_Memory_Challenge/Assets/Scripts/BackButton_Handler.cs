using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton_Handler : MonoBehaviour
{

    // This function will be called when the Android back button is pressed.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnBackButtonClicked();
            // Handle the back button press here.
            // You can implement your desired behavior, such as going back to a previous scene or showing a confirmation dialog.
            // For example, you can load a different scene when the back button is pressed:
            // SceneManager.LoadScene("YourSceneName");

            // Or you can quit the application:
            // Application.Quit();
        }
    }

    void OnBackButtonClicked()
    {
        switch(UI_Manager.Instance.CurrentScreen)
        {
            case ActiveScreen.HomeScreen:
               

                break;
            case ActiveScreen.ToySelectionScreen:
                UI_Manager.Instance.GetCurrentScreen().SetActive(false);
                UI_Manager.Instance.SetHomeScreen();
                break;
            case ActiveScreen.GamePlayScreen:
                break;
            case ActiveScreen.GameOverScreen:
                UI_Manager.Instance.GameOver_Screen.OnPlayAgainClicked();             
                break;
        }
    }
}
