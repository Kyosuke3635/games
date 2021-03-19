using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_move : MonoBehaviour
{
    float sin;
    Vector3 initialpos;

    // Start is called before the first frame update
    void Start()
    {
        initialpos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        sin = Mathf.Sin(Time.time);

        if (this.gameObject.tag == "wall_x")
        {
            transform.position = new Vector3(initialpos.x + sin * 30, initialpos.y , initialpos.z);
        }

        if (this.gameObject.tag == "wall_y")
        {
            transform.position = new Vector3(initialpos.x, initialpos.y + sin * 50 , initialpos.z);
        }

        if (this.gameObject.tag == "wall_z")
        {
            transform.position = new Vector3(initialpos.x, initialpos.y, initialpos.z + sin * 30);
        }
    }
}
