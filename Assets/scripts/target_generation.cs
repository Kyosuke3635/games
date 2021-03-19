using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_generation : MonoBehaviour
{
    public GameObject target;
    float span; //cleate time
    float delta; //time delta
    float r; //kyoku
    float theta; //theta

    public GameObject parent;

    Vector3 instant_pos; //Instant position

    // Start is called before the first frame update
    void Start()
    {
        span = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if (delta > span)
        {
            delta = 0;

            r = Random.Range(0f, 220f);
            theta = Random.Range(-Mathf.PI, Mathf.PI);

            instant_pos.x = r * Mathf.Cos(theta);
            instant_pos.y = Random.Range(0f, 700f);
            instant_pos.z = r * Mathf.Sin(theta);

            GameObject Target = Instantiate(target,instant_pos,Quaternion.Euler(90f, 0f, 0f)) as GameObject;
            Target.transform.parent = parent.transform;

            //Change the name of a clone
            Target.name = "target";
        }
    }
}
