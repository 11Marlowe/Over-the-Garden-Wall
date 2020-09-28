using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingController : MonoBehaviour
{
    private BuildingData buildingData;
    private bool rightTriggerPressed;
    private bool leftTriggerPressed;

    // Start is called before the first frame update
    void Start()
    {
        rightTriggerPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        // this should not be here, player event system should handle this
        rotateBuilding();
    }

    private void rotateBuilding()
    {
        if (Input.GetAxis("RightTrigger") == 1)
        {
            if (!rightTriggerPressed)
            {
                this.transform.Rotate(new Vector3(0, 90, 0));
                rightTriggerPressed = true;
            }
        }
        else
        {
            rightTriggerPressed = false;
        }

        if (Input.GetAxis("LeftTrigger") == 1)
        {
            if (!leftTriggerPressed)
            {
                this.transform.Rotate(new Vector3(0, -90, 0));
                leftTriggerPressed = true;
            }
        }
        else
        {
            leftTriggerPressed = false;
        }
    }

    public void setBuilding(BuildingData buildingData)
    {
        this.buildingData = buildingData;
    }

    public void setData()
    {
        GameObject model = Instantiate(buildingData.model);
        model.transform.SetParent(this.transform);
        model.transform.localPosition = buildingData.offset;
        model.transform.rotation = Quaternion.identity;
    }
}
