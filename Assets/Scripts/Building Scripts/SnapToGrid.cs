using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToGrid : MonoBehaviour
{
    private Transform pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;

        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
            pos.transform.position = new Vector3(hit.point.x, 3, hit.point.z);
            pos.transform.position = new Vector3(Mathf.Clamp(Mathf.Round(pos.transform.position.x / GridController.gridScale) * GridController.gridScale, 0, GridController.gridSize - 1), 0, 
                Mathf.Clamp(Mathf.Round(pos.transform.position.z / GridController.gridScale) * GridController.gridScale, 0, GridController.gridSize - 1));
        }
    }
}
