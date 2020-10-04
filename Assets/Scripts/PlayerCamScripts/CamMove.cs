using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    private Transform camPos;
    public float speed;
    public float rotSpeed;
    private Vector3 velocity;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        camPos = this.GetComponent<Transform>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        velocity = new Vector3(h, 0, v);
        velocity *= speed * Time.deltaTime;

        Vector3 camF = Camera.main.transform.forward;
        Vector3 camR = Camera.main.transform.right;
        camF.y = 0;
        camR.y = 0;
        camF = camF.normalized;
        camR = camR.normalized;
        camPos.transform.position += (camF * velocity.z + camR * velocity.x);
        camPos.eulerAngles += new Vector3(0, Input.GetAxis("SecondStickH") * Time.deltaTime * rotSpeed, 0);
        camPos.eulerAngles += new Vector3(Input.GetAxis("SecondStickV") * Time.deltaTime * rotSpeed, 0, 0);
    }
}
