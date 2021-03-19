using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{

    public GameObject camera;

    float rotateSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, Input.GetAxis("Mouse Y") * rotateSpeed, 0);

        camera.transform.RotateAround(camera.transform.position, Vector3.up, angle.x);
        camera.transform.RotateAround(camera.transform.position, transform.right, angle.y * -1);
    }
}
