using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject building;
    public BuildingData wellData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("joystick button 0"))
        {
           GameObject well =  Instantiate(building);
           well.GetComponent<BuildingController>().setBuilding(wellData);
           well.GetComponent<BuildingController>().setData();
        }

        if(Input.GetKeyDown("joystick button 3"))
        {
            Debug.Log("SSS");
        }
    }
}
