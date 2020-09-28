using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour
{
    public GameObject gridMarker;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject o = GameObject.Instantiate(gridMarker, new Vector3(Mathf.Round(i / 1f) * 1f, 0,
                    Mathf.Round(j / 1f) * 1f), Quaternion.identity);
                o.transform.SetParent(this.transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }
}
