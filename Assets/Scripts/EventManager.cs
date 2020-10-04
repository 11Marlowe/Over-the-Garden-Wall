using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void AddBuildingToGrid();
    public static event AddBuildingToGrid buildingPlaced;

    public delegate void SelectBuilding(GridController.BuildingType type);
    public static event SelectBuilding buildingSelected;

    public static void placeBuilding()
    {
        buildingPlaced?.Invoke();
    }

    public static void selectBuilding(GridController.BuildingType type)
    {
        buildingSelected?.Invoke(type);
    }
}
