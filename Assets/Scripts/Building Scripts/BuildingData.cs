using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="BuildingData", menuName ="BuildingData")]
public class BuildingData : ScriptableObject
{
    public Vector3 offset;
    public GameObject model;
}
