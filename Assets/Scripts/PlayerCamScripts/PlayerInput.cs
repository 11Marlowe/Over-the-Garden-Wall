using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject building;
    public BuildingData wellData;
    private EventManager eventManager;
    private bool inMenu;

    // Start is called before the first frame update
    void Start()
    {
        eventManager = this.GetComponent<EventManager>();
        inMenu = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(inMenu)
        {

        }
        else
        {

        }

        if(Input.GetKeyDown("joystick button 0"))
        {
           
        }

        if(Input.GetKeyDown("joystick button 3"))
        {
            EventManager.placeBuilding();
        }

        if (Input.GetKeyDown("joystick button 7"))
        {
            GameObject canvas = GameObject.Find("Canvas");
            canvas.transform.GetChild(0).gameObject.SetActive(true);
            inMenu = true;
        }
    }
}
