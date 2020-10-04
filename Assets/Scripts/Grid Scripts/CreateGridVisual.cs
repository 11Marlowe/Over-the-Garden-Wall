using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGridVisual : MonoBehaviour
{
    public GameObject gridMarker;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < GridController.gridSize; i++)
        {
            for (int j = 0; j < GridController.gridSize; j++)
            {
                GameObject o = GameObject.Instantiate(gridMarker, new Vector3(Mathf.Round(i / GridController.gridScale) * GridController.gridScale, 0,
                    Mathf.Round(j / GridController.gridScale) * GridController.gridScale), Quaternion.identity);
                o.transform.SetParent(this.transform);
            }
        }
    }
}
