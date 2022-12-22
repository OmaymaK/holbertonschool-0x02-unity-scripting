using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("up"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, speed);
        }
        if (Input.GetKey("right"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(speed, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -speed);
        }
        if (Input.GetKey("left"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-speed, 0, 0);
        }
        
    }
}
