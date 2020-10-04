using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBuildingButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onClickSelectBuilding(int type)
    {
        EventManager.selectBuilding((GridController.BuildingType) type);
    }
}
