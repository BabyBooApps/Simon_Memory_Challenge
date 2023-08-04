using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyManager : MonoBehaviour
{
    public List<Toy> ToyList = new List<Toy>();
    // Start is called before the first frame update
  

    public Toy GetToy(int id)
    {
        for(int i = 0; i < ToyList.Count; i++ )
        {
            if(id == ToyList[i].Toy_Id)
            {
                return ToyList[i];
            }
        }

        return ToyList[0];
    }

    
}
