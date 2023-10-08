using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToyTile_UI : MonoBehaviour
{
    public Image Bg;
    public Image Toy_Image;
    public string Toy_Name;
    public TMP_Text ToyName;
    public int Toy_id;
    public GameObject Lock;
    public bool isUnlocked;
    public Image Lock_Img;
    public int coinsToBuy;
}
