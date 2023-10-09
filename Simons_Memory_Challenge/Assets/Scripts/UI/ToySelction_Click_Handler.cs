using UnityEngine.UI;
using UnityEngine;

public class ToySelction_Click_Handler : MonoBehaviour
{
    public Button button;
    public ToySelection ToySelection;
    public ToyTile_UI Toy_Tile;

    private void Start()
    {
        ToySelection = FindAnyObjectByType(typeof(ToySelection)) as ToySelection;
        Toy_Tile = GetComponentInParent<ToyTile_UI>() ;
        button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(HandleButtonClick);
        }
    }

    private void HandleButtonClick()
    {
        // Handle the button click here
        Debug.Log("Button Clicked!");
        if(ToySelection == null)
        {
            ToySelection = FindAnyObjectByType(typeof(ToySelection)) as ToySelection;
        }

        if(Toy_Tile == null)
        {
            Toy_Tile = GetComponentInParent<ToyTile_UI>();
        }
        if(PlayerPrefs_Manager.Instance.GetLockStatus(Toy_Tile.Toy_Name.ToString()))
        {
            AudioManager.Instance.PlayShortSound(AudioManager.Instance.Button_Click);
            ToySelection.ToyTile_Clicked(Toy_Tile.Toy_id);
        }else
        {
            Debug.Log("Toy Locked !!!");
            UI_Manager.Instance.Activate_Buy_Toy_Screen(Toy_Tile);
        }
        
    }
}
