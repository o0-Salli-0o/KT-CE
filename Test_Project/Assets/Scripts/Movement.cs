using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    float speed = 10;
    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        // save input
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        // determine new position
        float xNew = transform.position.x + xInput * speed * Time.deltaTime;
        float yNew = transform.position.y + yInput * speed * Time.deltaTime;

        transform.position = new Vector3(xNew, yNew, 0);

        //Debug.Log(i++); 

    }
}
