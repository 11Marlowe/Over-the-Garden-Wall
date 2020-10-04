using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    public enum BuildingType
    {
        Well, Building
    }

    public static readonly int gridSize = 10;
    public static readonly float gridScale = 1f;

    public GameObject[,] buildings;
    public BuildingData[] buildingDatas;
    private Dictionary<BuildingType, BuildingData> buildingDataLookup;

    private GameObject selectedBuilding;

    // Start is called before the first frame update
    void Start()
    {
        buildings = new GameObject[gridSize, gridSize];
    }

    private void placeSelectedBuildingInGrid()
    {
        Debug.Log("DEBUG");
        
    }

    private void setSelectedBuilding(BuildingType type)
    {
        Debug.Log(type.ToString());
        //GameObject well =  Instantiate(building);
        //well.GetComponent<BuildingController>().setBuilding(wellData);
        //well.GetComponent<BuildingController>().setData();
    }

    private void OnEnable()
    {
        EventManager.buildingPlaced += placeSelectedBuildingInGrid;
        EventManager.buildingSelected += setSelectedBuilding;
    }

    private void OnDisable()
    {
        EventManager.buildingPlaced -= placeSelectedBuildingInGrid;
        EventManager.buildingSelected -= setSelectedBuilding;
    }
}
